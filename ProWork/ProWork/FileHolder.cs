using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProWork
{
    public partial class FileHolder : UserControl
    {

        public const short FileSize = 100;
        private List<Carpeta> carpetas = new List<Carpeta>();
        private List<Archivo> archivos = new List<Archivo>();
        string consulta = "";

        public FileHolder()
        {
            InitializeComponent();
            ContextMenuStrip contexto = new();
        }
        public async void MostrarCarpetas()
        {
            var con = await Program.openConnectionAsync();
            MySqlCommand nombres = new("select idcarpeta, nombre from carpeta where idcarpetaPadre is NULL and existencia = true;", con);
            MySqlDataReader reader = await nombres.ExecuteReaderAsync();
            Truncate();
            while (await reader.ReadAsync())
            {
                Carpeta carpeta = new Carpeta();
                carpeta.id = reader.GetString(0);
                carpeta.Nombre = reader.GetString(1);
                this.Add(carpeta);
            }
            await reader.CloseAsync();
            Program.closeOpenConnection();
            Entrar.Invoke(null, null);
        }
        private void FileHolder_Resize(object sender, EventArgs e)
        {
            ResetElementos();
            this.AutoScroll = false;
            this.HorizontalScroll.Visible = false;
            this.AutoScroll = true;
        }

        private void ResetElementos()
        {
            int n = 0;
            int fila = 0;
            int y = 0;
            for (int i = 0; i < carpetas.Count + archivos.Count; i++)
            {
                if ((10 + FileSize) * (i - n) + FileSize > this.ClientSize.Width)
                {
                    n = i;
                    fila++;
                    y = (10 + FileSize) * fila;
                }
                if (carpetas.Count > i)
                {
                    carpetas[i].Location = new Point((10 + FileSize) * (i - n), y);
                }
                else
                {
                    archivos[i - carpetas.Count].Location = new Point((10 + FileSize) * (i - n), y);
                }
            }
        }

        private void FileHolder_Load(object sender, EventArgs e)
        {
            RefreshData();
            MostrarCarpetas();
        }

        public void Add(Carpeta a)
        {
            carpetas.Add(a);
            a.CarpetaDoubleClick += Open;
            a.LostFoco += ChangeName;
            a.Eliminar += EliminarCarpeta;
            this.Controls.Add(a);
            ResetElementos();
        }

        public void Add(Archivo a)
        {
            archivos.Add(a);
            this.Controls.Add(a);
            ResetElementos();
        }

        public async void RefreshData()
        {
            //Para actualizar
            List<string> listTabla = new List<string>();
            List<string> listIdTabla = new List<string>();
            List<string> listId = new List<string>();

            var con = await Program.openConnectionAsync();
            FilesResource.ListRequest listRequest = GoogleInfo.Servicio.Files.List();
            listRequest.Fields = "files(id, mimeType)";

            var request = await listRequest.ExecuteAsync();

            if (request.Files != null && request.Files.Count > 0)
            {
                foreach (var file in request.Files)
                {
                    if (file.MimeType != "application/vnd.google-apps.folder")
                    {
                        MySqlCommand cmd = new($"select '{file.Id}',if('{file.Id}' IN (select idarchivo from archivo), 1, null) from archivo;", con);
                        MySqlDataReader rdr1 = await cmd.ExecuteReaderAsync();
                        while (await rdr1.ReadAsync())
                        {
                            if (await rdr1.IsDBNullAsync(1))
                            {
                                listId.Add(rdr1.GetString(0));
                                listIdTabla.Add("idarchivo");
                                listTabla.Add("archivo");
                            }

                        }
                        await rdr1.CloseAsync();
                    }
                    else
                    {
                        MySqlCommand cmd = new($"select '{file.Id}',if('{file.Id}' IN (select idcarpeta from carpeta), 1, null) from carpeta;", con);
                        MySqlDataReader rdr2 = await cmd.ExecuteReaderAsync();
                        while (await rdr2.ReadAsync())
                        {
                            if (await rdr2.IsDBNullAsync(1))
                            {
                                listId.Add(rdr2.GetString(0));
                                listIdTabla.Add("idcarpeta");
                                listTabla.Add("carpeta");
                            }
                        }
                        await rdr2.CloseAsync();
                    }
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    MySqlCommand cmd = new($"update {listTabla[i]} set existencia = false where {listIdTabla[i]} = '{listId[i]}';", con);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            Program.closeOpenConnection();
        }

        public async Task RefreshData(string fileID, int proyecto, MySqlConnection con)
        {
            List<string> names = new();
            List<string> ids = new();
            List<string> format = new();
            List<bool> tipo = new();
            List<string> idsnot = new();
            List<string> tiponot = new();
            List<string> namesnot = new();
            List<string> formatnot = new();

            FilesResource.ListRequest listRequest = GoogleInfo.Servicio.Files.List();
            listRequest.Fields = "files(id, mimeType, name)";
            listRequest.Q = $"'{fileID}' in parents";

            var request = await listRequest.ExecuteAsync();

            if (request.Files != null && request.Files.Count > 0)
            {
                foreach (var file in request.Files)
                {
                    if (file.MimeType == "application/vnd.google-apps.folder")
                    {
                        ids.Add(file.Id);
                        names.Add(file.Name);
                        tipo.Add(false);
                        format.Add("");
                    }
                    else
                    {
                        ids.Add(file.Id);
                        names.Add(file.Name);
                        string formato = file.MimeType.Split('/')[1];
                        format.Add(formato);
                        tipo.Add(true);
                    }
                }
                if (ids.Count > 0)
                {
                    for (int i = 0; i < ids.Count; i++)
                    {
                        if(tipo[i] == false)
                        {
                            if (ids.Count == 1)
                            {
                                consulta = $"SELECT IF('{ids[i]}' IN (select idcarpeta from carpeta where idcarpetapadre = '{fileID}'), '{ids[i]}', null),'{ids[i]}','{names[i]}', 'No','carpeta' from carpeta ;";
                            }
                            else if (i != (ids.Count - 1))
                            {
                                consulta += $"SELECT IF('{ids[i]}' IN (select idcarpeta from carpeta where idcarpetapadre = '{fileID}'), '{ids[i]}', null),'{ids[i]}','{names[i]}', 'No', 'carpeta' from carpeta UNION ";
                            }
                            else
                            {
                                consulta += $"SELECT IF('{ids[i]}' IN (select idcarpeta from carpeta where idcarpetapadre = '{fileID}'), '{ids[i]}', null),'{ids[i]}','{names[i]}', 'No', 'carpeta' from carpeta; ";
                            }
                        }
                        else
                        {
                            if (ids.Count == 1)
                            {
                                consulta = $"SELECT IF('{ids[i]}' IN (select idarchivo from contiene where idcarpeta = '{fileID}'), '{ids[i]}', null),'{ids[i]}','{names[i]}','{format[i]}','archivo' from archivo a, contiene c where a.idarchivo = c.idarchivo;";
                            }
                            else if (i != (ids.Count - 1))
                            {
                                consulta += $"SELECT IF('{ids[i]}' IN (select idarchivo from contiene where idcarpeta = '{fileID}'), '{ids[i]}', null),'{ids[i]}','{names[i]}','{format[i]}','archivo' from archivo a, contiene c where a.idarchivo = c.idarchivo UNION ";
                            }
                            else
                            {
                                consulta += $"SELECT IF('{ids[i]}' IN (select idarchivo from contiene where idcarpeta = '{fileID}'), '{ids[i]}', null),'{ids[i]}','{names[i]}','{format[i]}','archivo' from archivo a, contiene c where a.idarchivo = c.idarchivo;";
                            }
                        }
                    }
                    MySqlCommand cmd1 = new(consulta, con);
                    MySqlDataReader reader = await cmd1.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        if (await reader.IsDBNullAsync(0))
                        {
                            if (reader.GetString(3) == "No")
                            {
                                idsnot.Add(reader.GetString(1));
                                namesnot.Add(reader.GetString(2));
                                formatnot.Add(reader.GetString(3));
                                tiponot.Add(reader.GetString(4));
                            }
                            else
                            {
                                idsnot.Add(reader.GetString(1));
                                namesnot.Add(reader.GetString(2));
                                formatnot.Add(reader.GetString(3));
                                tiponot.Add(reader.GetString(4));
                            }
                        }

                    }
                    await reader.CloseAsync();
                    if (consulta != "")
                    {
                        string consultaDerivada = "";
                        for (int i = 0; i < idsnot.Count; i++)
                        {
                            if (formatnot[i] == "No")
                            {
                                consultaDerivada += $"insert into carpeta(idcarpetapadre, idproyecto, idcarpeta, nombre) values('{fileID}',{proyecto},'{idsnot[i]}','{namesnot[i]}'); insert into carga(descripcion, idcarpeta, idproyecto) values('n', '{idsnot[i]}',{proyecto}); ";
                            }
                            else
                            {
                                consultaDerivada += $"insert into archivo(formato, idarchivo, nombre) values('{formatnot[i]}','{idsnot[i]}','{namesnot[i]}'); insert into carga(descripcion, idcarpeta, idproyecto, idarchivo) values('n', '{fileID}', {proyecto}, '{idsnot[i]}'); insert into contiene(idarchivo, idcarpeta) values('{idsnot[i]}','{fileID}'); ";
                            }
                        }

                        if (consultaDerivada != "")
                        {
                            DialogResult result = MessageBox.Show("Quiere sincronizar usted?", "Ah", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                MySqlCommand cmd2 = new(consultaDerivada, con);
                                await cmd2.ExecuteNonQueryAsync();
                            }
                        }
                    }

                }

            }
        }
        public void Truncate()
        {
            this.Controls.Clear();
            carpetas.Clear();
            archivos.Clear();
        }

        public async void Open(object sender, EventArgs e)
        {
            Truncate();
            var con = await Program.openConnectionAsync();

            MySqlCommand data = new($"select idproyecto from carpeta where idcarpeta = '{sender}';", con);
            MySqlDataReader rdr1 = await data.ExecuteReaderAsync();
            await rdr1.ReadAsync();
            int proyecto = rdr1.GetInt32(0);
            await rdr1.CloseAsync();

            await RefreshData(sender.ToString(), proyecto, con);

            MySqlCommand nombres = new($"select c.idcarpeta, c.nombre, null'idarchivo', null'nombre' from carpeta c where c.idcarpetapadre = '{sender}' and existencia = true UNION select null, null, a.idarchivo, a.nombre from archivo a, contiene co where a.idarchivo = co.idarchivo and co.idcarpeta = '{sender}' and existencia = true;", con);
            MySqlDataReader reader = await nombres.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                if (!(await reader.IsDBNullAsync(0)))
                {
                    Carpeta carpeta = new Carpeta();
                    carpeta.id = reader.GetString(0);
                    carpeta.Nombre = reader.GetString(1);
                    this.Add(carpeta);
                }
                else
                {
                    Archivo archivo = new Archivo();
                    archivo.id = reader.GetString(2);
                    archivo.Nombre = reader.GetString(3);
                    this.Add(archivo);
                }
            }
            await reader.CloseAsync();
            Program.closeOpenConnection();
            Entrar.Invoke(sender, e);
        }

        public event EventHandler Entrar;

        private void FileHolder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(this, e.Location);
            }
        }

        public async void ChangeName(object sender, EventArgs e)
        {
            var con = await Program.openConnectionAsync();
            MySqlCommand cmd = new($"update carpeta set nombre = '{(((Carpeta)sender).rtb).Text}' where idcarpeta = '{((Carpeta)sender).id}';",con);
            await cmd.ExecuteNonQueryAsync();
            Program.closeOpenConnection();
        }
        public async void EliminarCarpeta(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que quieres eliminar esta carpeta?", "Eliminar carpeta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var con = await Program.openConnectionAsync();
                    FilesResource.DeleteRequest request = GoogleInfo.Servicio.Files.Delete(((Carpeta)sender).id);
                    await request.ExecuteAsync();
                    MySqlCommand cmd = new($"update carpeta set existencia = false where idcarpeta = '{((Carpeta)sender).id}';");
                    await cmd.ExecuteNonQueryAsync();
                    Controls.Remove((Carpeta)sender);
                    Program.closeOpenConnection();
                }
                catch (Exception ex)
                {
                    Program.closeOpenConnection();
                    MessageBox.Show(ex.Message);
                    Clipboard.SetText(ex.Message);
                }
            }
        }
        public static async Task<string> Subir(Carpeta carpeta, string idcarpetapadre)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = "Carpeta indefinida",
                    MimeType = "application/vnd.google-apps.folder",
                    Parents = new List<string>
                        {
                            idcarpetapadre
                        }
                };
                var request = GoogleInfo.Servicio.Files.Create(fileMetadata);
                request.Fields = "id";
                var file = await request.ExecuteAsync();

                return file.Id;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.");
                return null;
            }
        }

        public static async Task<string> Subir(Carpeta carpeta)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = "Carpeta indefinida",
                    MimeType = "application/vnd.google-apps.folder",
                };
                var request = GoogleInfo.Servicio.Files.Create(fileMetadata);
                request.Fields = "id";
                var file = await request.ExecuteAsync();

                return file.Id;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.");
                return null;
            }
        }

        public static async Task Subir(List<string> filePath, Carpeta carpeta, long idproyecto)
        {
            try
            {
                List<string> filtros = new List<string>();
                List<string> newCarpeta = new List<string>();

                var con = await Program.openConnectionAsync();
                MySqlCommand cmd = new($"select idcarpeta, filtros from carpeta where idcarpetapadre = {carpeta.id}", con);
                MySqlDataReader reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    newCarpeta.Add(reader.GetString(0));
                    filtros.Add(reader.GetString(1));
                }
                string consulta = "";
                foreach (var item in filePath)
                {
                    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                    {
                        Name = Path.GetFileName(item),
                        Parents = new List<string>
                        {
                            carpeta.id
                        }
                    };
                    using (var stream = new FileStream(item, FileMode.Open))
                    {
                        var request = GoogleInfo.Servicio.Files.Create(fileMetadata, stream, "");
                        request.Fields = "id, name";
                        await request.UploadAsync();

                        var file = request.ResponseBody;

                        string format = file.MimeType.Split('/')[1];

                        for(int i = 0; i < filtros.Count; i++)
                        {
                            string[] filtrar = filtros[i].ToLower().Replace(" ", string.Empty).Split(',');

                            if(Array.Exists(filtrar, i => i == file.MimeType))
                            {
                                FilesResource.UpdateRequest updateRequest = GoogleInfo.Servicio.Files.Update(new Google.Apis.Drive.v3.Data.File(), file.Id);
                                updateRequest.Fields = "id";
                                updateRequest.AddParents = newCarpeta[i];
                                updateRequest.RemoveParents = carpeta.id;
                                consulta += $"insert into archivo(formato, idarchivo, nombre, size) values('{format}','{file.Id}','{file.Name}', {file.Size}); insert into carga(idusuario, descripcion, idcarpeta, idproyecto, idarchivo) values({Program.user},'s', '{file.Id}', {idproyecto}, '{file.Id}'); insert into contiene(idarchivo, idcarpeta) values('{file.Id}','{newCarpeta[i]}'); ";

                                file = updateRequest.Execute();
                            }
                            else
                            {
                                FilesResource.UpdateRequest updateRequest = GoogleInfo.Servicio.Files.Update(new Google.Apis.Drive.v3.Data.File(), file.Id);
                                updateRequest.Fields = "id";
                                updateRequest.AddParents = newCarpeta[i];
                                updateRequest.RemoveParents = carpeta.id;

                                consulta += $"insert into archivo(formato, idarchivo, nombre, size) values('{format}','{file.Id}','{file.Name}', {file.Size}); insert into carga(idusuario, descripcion, idcarpeta, idproyecto, idarchivo) values({Program.user}'s', '{file.Id}', {idproyecto}, '{file.Id}'); insert into contiene(idarchivo, idcarpeta) values('{file.Id}','{newCarpeta[i]}'); ";

                                file = updateRequest.Execute();
                            }
                        }
                    }
                }
                MySqlCommand cmd1 = new(consulta, con);
                await cmd.ExecuteNonQueryAsync();
                Program.closeOpenConnection();
            }
            catch (Exception e)
            {
                Program.closeOpenConnection();
                MessageBox.Show(e.Message);
            }
        }

        public async Task Mover()
        {

        }
        private async void añadirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carpeta carpeta = new Carpeta();
            if (await Subir(carpeta, Ruta.carpetaActual) != null && Ruta.proyectoActual != 0)
            {
                var con = await Program.openConnectionAsync();
                try
                {
                    carpeta.id = await Subir(carpeta, Ruta.carpetaActual);
                    MySqlCommand cmd = new($"insert into carpeta(idcarpeta, idcarpetapadre, idproyecto, nombre) values('{carpeta.id}','{Ruta.carpetaActual}',{Ruta.proyectoActual},'Nueva carpeta');", con);
                    this.Add(carpeta);
                    await carpeta.CambiarNombre();
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al agregar la carpeta.");
                }
                Program.closeOpenConnection();
            }
        }
    }
}