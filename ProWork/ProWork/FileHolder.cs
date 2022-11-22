using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MediaToolkit.Standard.Services;
using MediaToolkit.Standard.Tasks;
using System.IO;
using System.Reflection;

namespace ProWork
{
    public partial class FileHolder : UserControl
    {

        public const short FileSize = 100;
        public List<Carpeta> carpetasL = new List<Carpeta>();
        public List<Archivo> archivosL = new List<Archivo>();
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
            for (int i = 0; i < carpetasL.Count + archivosL.Count; i++)
            {
                if ((10 + FileSize) * (i - n) + FileSize > this.ClientSize.Width)
                {
                    n = i;
                    fila++;
                    y = (10 + FileSize) * fila;
                }
                if (carpetasL.Count > i)
                {
                    carpetasL[i].Location = new Point((10 + FileSize) * (i - n), y);
                }
                else
                {
                    archivosL[i - carpetasL.Count].Location = new Point((10 + FileSize) * (i - n), y);
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
            carpetasL.Add(a);
            a.CarpetaDoubleClick += Open;
            a.LostFoco += ChangeName;
            a.Eliminar += Eliminar;
            a.Deseleccionar += DeseleccionCar;
            a.DescargarCarpeta += IniciarDescarga;
            a.CambiarFiltros += CambiarFiltro;
            this.Controls.Add(a);
            ResetElementos();
        }

        public void Add(Archivo a)
        {
            archivosL.Add(a);
            a.Descargar += IniciarDescarga;
            a.Deseleccionar += DeseleccionArch;
            a.Eliminar += Eliminar;
            this.Controls.Add(a);
            ResetElementos();
        }

        public void DeseleccionCar(object sender, EventArgs e)
        {
            ((Carpeta)sender).seleccionado = false;
        }

        public void DeseleccionArch(object sender, EventArgs e)
        {
            ((Archivo)sender).seleccionado = false;
        }

        public static async void RefreshData()
        {
            List<string> listTabla = new List<string>();
            List<string> listId = new List<string>();
            List<string> listnotId = new List<string>();
            List<string> listnotTabla = new List<string>();

            var con = await Program.openConnectionAsync();
            FilesResource.ListRequest listRequest = GoogleInfo.Servicio.Files.List();
            listRequest.Fields = "files(id, mimeType)";

            var request = await listRequest.ExecuteAsync();

            MySqlCommand ids = new("select idarchivo from archivo UNION select idcarpeta from carpeta;", con);
            MySqlDataReader read = await ids.ExecuteReaderAsync();
            while(await read.ReadAsync())
            {
                    listId.Add(read.GetString(0));
            }
            await read.CloseAsync();
            if (request.Files != null && request.Files.Count > 0)
            {
                foreach (var file in request.Files)
                {
                    if(!(listId.Contains(file.Id)))
                    {
                        if(file.MimeType == "application/vnd.google-apps.folder")
                        {
                            listnotTabla.Add("idcarpeta");
                            listTabla.Add("carpeta");
                            listnotId.Add(file.Id);
                        }
                        else
                        {
                            listnotTabla.Add("idarchivo");
                            listTabla.Add("archivo");
                            listnotId.Add(file.Id);
                        }
                    }
                    
                }
                string consultaDerivada = "";
                for (int i = 0; i < listnotId.Count; i++)
                {
                    if (listnotId.Count == i)
                    {
                        consultaDerivada += $"update {listTabla[i]} set existencia = false where {listnotTabla[i]} = '{listnotId[i]}'; ";
                    }
                    else
                    {
                        consultaDerivada += $"update {listTabla[i]} set existencia = false where {listnotTabla[i]} = '{listnotId[i]}'; ";
                    }
                }
                if (consultaDerivada != "")
                {
                    MySqlCommand cmd1 = new(consultaDerivada, con);
                    await cmd1.ExecuteNonQueryAsync();
                }
            }
            Program.closeOpenConnection();
        }

        public async void IniciarDescarga(object sender, EventArgs e)
        {
            List<(string nombre, string id)> carpeta = new();
            List<(string id, string nombre)> archivo = new();

            List<string> excluir = new();
            var con = await Program.openConnectionAsync();
            MySqlCommand prev = new("select imagenPrevisualizacion from archivo;", con);
            MySqlDataReader read = await prev.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                if (!(await read.IsDBNullAsync(0)))
                    excluir.Add(read.GetString(0));
            }
            await read.CloseAsync();
            Program.closeOpenConnection();

            MessageBox.Show("Seleccione el lugar para guardar las carpetas seleccionadas y sus contenidos.");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                foreach (Carpeta c in ConseguirC(this))
                {
                    if (c.seleccionado)
                    {
                        carpeta.Add((c.Nombre, c.id));
                    }
                }
                if(carpeta.Count > 0)
                {
                    await DownloadCar(carpeta, fbd.SelectedPath, excluir);
                }

                foreach (Archivo a in ConseguirA(this))
                {
                    if (a.seleccionado)
                    {
                        archivo.Add((a.id, a.Nombre));
                    }
                }
                if (archivo.Count > 0)
                {
                    await DownloadArch(archivo, fbd.SelectedPath);
                }
            }
        }

        public static async Task DownloadCar(List<(string nombre, string id)> carpeta, string objPath, List<string> excluir)
        {
            List<(string id, string name)> fileIDa = new();
            List<(string nombre, string id)> carpetaN = new();
            string ruta;

            foreach (var item in carpeta)
            {
                var contenido = GoogleInfo.Servicio.Files.List();
                contenido.Fields = "files(*)";
                contenido.Q = $"'{item.id}' in parents";

                ruta = objPath + @$"\{item.nombre}";
                if(Directory.Exists((objPath + @$"\{item.nombre}")) == false)
                {
                    Directory.CreateDirectory(ruta);
                }

                var request = await contenido.ExecuteAsync();

                foreach(var file in request.Files)
                {
                    if (!(excluir.Contains(file.Id)))
                    {
                        if (file.MimeType == "application/vnd.google-apps.folder")
                        {
                            carpetaN.Add((file.Name, file.Id));
                            Directory.CreateDirectory(@$"{ruta}\{file.Name}");
                        }
                        else
                        {
                            fileIDa.Add((file.Id, file.Name));
                        }
                    }
                }
                await DownloadArch(fileIDa, $"{ruta}");
                fileIDa.Clear();
                await DownloadCar(carpetaN, $"{ruta}", excluir);
                carpetaN.Clear();
            }
        }

        public static async Task DownloadArch(List<(string id, string Name)> fileIDA, string objPath)
        {
            foreach (var item in fileIDA)
            {
                FilesResource.GetRequest request = GoogleInfo.Servicio.Files.Get(item.id);
                var stream = new MemoryStream();

                await request.DownloadAsync(stream);

                string filePath = Path.Combine(objPath, item.Name);
                using (var fileStream = File.Create(filePath))
                {
                   try
                   {
                      stream.Seek(0, SeekOrigin.Begin);
                      stream.CopyTo(fileStream);
                   }
                      catch (Exception ex)
                   {
                      MessageBox.Show("Ha ocurrido un error al intentar descargar.");
                   }
            }
        }

}

        private static async Task RefreshData(string fileID, int proyecto, MySqlConnection con)
        {
            List<string> names = new();
            List<string> ids = new();
            List<string> format = new();
            List<string> idsnot = new();

            string month = "";
            string day = "";
            if (DateTime.Now.Month < 10)
            {
                month = $"0{DateTime.Now.Month}";
            }
            else { month = DateTime.Now.Month.ToString(); }

            if (DateTime.Now.Day < 10)
            {
                day = $"0{DateTime.Now.Day}";
            }
            else { day = DateTime.Now.Day.ToString(); }

            FilesResource.ListRequest listRequest = GoogleInfo.Servicio.Files.List();
            listRequest.Fields = "files(id, mimeType, name)";
            listRequest.Q = $"'{fileID}' in parents";

            var request = await listRequest.ExecuteAsync();

            MySqlCommand idsR = new("select idarchivo,0 from archivo UNION select idcarpeta,1 from carpeta UNION select imagenPrevisualizacion,0 from archivo;", con);
            MySqlDataReader read = await idsR.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                if (read.GetBoolean(1))
                {
                    ids.Add(read.GetString(0));
                }
                else
                {
                    if(!(await read.IsDBNullAsync(0)))
                    {
                        ids.Add(read.GetString(0));
                    }
                }
            }
            await read.CloseAsync();
            if (request.Files != null && request.Files.Count > 0)
            {
                foreach (var file in request.Files)
                {
                    if(!(ids.Contains(file.Id)))
                    {
                        names.Add(file.Name);
                        idsnot.Add(file.Id);
                        string formato = file.MimeType.Split('/')[1];
                        format.Add(formato);

                    }
                }
                string consulta = "";
                for (int i = 0; i < idsnot.Count; i++)
                {
                    if (format[i] == "vnd.google-apps.folder")
                    {
                        consulta += $"insert into carpeta(idcarpetapadre, idproyecto, idcarpeta, nombre, existencia) values('{fileID}',{proyecto},'{idsnot[i]}','{names[i]}', true); insert into carga(descripcion, idcarpeta, idproyecto, fehca) values('n', '{idsnot[i]}',{proyecto}, '{DateTime.Now.Year}-{month}-{day}'); ";
                    }
                    else
                    {
                        consulta += $"insert into archivo(formato, idarchivo, nombre, existencia) values('{format[i]}','{idsnot[i]}','{names[i]}', true); insert into carga(descripcion, idcarpeta, idproyecto, idarchivo, fecha) values('n', '{fileID}', {proyecto}, '{idsnot[i]}', '{DateTime.Now.Year}-{month}-{day}'); insert into contiene(idarchivo, idcarpeta) values('{idsnot[i]}','{fileID}'); ";
                    }
                }
                if (consulta != "")
                {
                    DialogResult result = MessageBox.Show("Se han detectado cambios. ¿Quisiera sincronizar? Puede tardar", "Modificaciones", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MySqlCommand cmd2 = new(consulta, con);
                        await cmd2.ExecuteNonQueryAsync();
                    }
                }
            }
        }

        public void Truncate()
        {
            this.Controls.Clear();
            carpetasL.Clear();
            archivosL.Clear();
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

            MySqlCommand nombres = new($"select c.idcarpeta, c.nombre, c.filtro, null'idarchivo', null'nombre', null'imagenPrevisualizacion' from carpeta c where c.idcarpetapadre = '{sender}' and existencia = true UNION select null, null, null, a.idarchivo, a.nombre, a.imagenPrevisualizacion from archivo a, contiene co where a.idarchivo = co.idarchivo and co.idcarpeta = '{sender}' and existencia = true;", con);
            MySqlDataReader reader = await nombres.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                if (!(await reader.IsDBNullAsync(0)))
                {
                    Carpeta carpeta = new Carpeta();
                    carpeta.id = reader.GetString(0);
                    carpeta.Nombre = reader.GetString(1);
                    carpeta.mimeTypes = reader.GetString(2);
                    this.Add(carpeta);
                }
                else
                {
                    Archivo archivo = new Archivo();
                    archivo.id = reader.GetString(3);
                    archivo.Nombre = reader.GetString(4);
                    if (!(await reader.IsDBNullAsync(5)))
                    {
                        archivo.previsual = reader.GetString(5);
                    }
                    this.Add(archivo);
                }
            }
            await reader.CloseAsync();
            Program.closeOpenConnection();
            Entrar.Invoke(sender, e);

            await CargarImagen();
        }

        public event EventHandler Entrar;

        private void FileHolder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(this, e.Location);
            }
        }

        private async void CambiarFiltro(object sender, string filtros)
        {
            string vfiltro = "";
            var con = await Program.openConnectionAsync();
            MySqlCommand comp = new($"select filtro from carpeta where idcarpeta = '{((Carpeta)sender).id}';", con);
            MySqlDataReader read = await comp.ExecuteReaderAsync();
            await read.ReadAsync();
            if(await read.IsDBNullAsync(0))
            {
                vfiltro = read.GetString(0);
            }
            await read.CloseAsync();
            if(vfiltro == "")
            {
                if(((Carpeta)sender).mimeTypes != vfiltro)
                {
                    MySqlCommand cambiar = new($"update carpeta set filtro = '{filtros}' where idcarpeta = '{((Carpeta)sender).id}';",con);
                    await cambiar.ExecuteNonQueryAsync();
                }
            }
            Program.closeOpenConnection();
        }

        public async void ChangeName(object sender, EventArgs e)
        {
            var con = await Program.openConnectionAsync();
            MySqlCommand cmd = new($"update carpeta set nombre = '{(((Carpeta)sender).rtb).Text}' where idcarpeta = '{((Carpeta)sender).id}';",con);
            await cmd.ExecuteNonQueryAsync();
            Program.closeOpenConnection();
        }

        public async void Eliminar(object sender, EventArgs e)
        {
            List<(string id, string Nombre)> carpetas = new();
            List<(string id, string Nombre, string prev)> archivos = new();

            foreach (Carpeta c in ConseguirC(this))
            {
                if(c.seleccionado == true)
                {
                    carpetas.Add((c.id, c.Nombre));
                }
            }
            if (carpetas.Count == 1)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que quieres eliminar la carpeta {carpetas[0].Nombre}?", "Eliminar carpeta", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await EliminarCarpeta(carpetas);
                    await GoogleInfo.Servicio.Files.Delete(carpetas[0].id).ExecuteAsync();
                    foreach(Carpeta c in ConseguirC(this))
                    {
                        Controls.Remove(c);
                        carpetasL.Remove(c);
                        ResetElementos();
                    }
                }
            }
            else if (carpetas.Count > 0)
            {
                await EliminarCarpeta(carpetas);
                foreach(var c in carpetas)
                {
                    await GoogleInfo.Servicio.Files.Delete(c.id).ExecuteAsync();
                }
            }

            foreach (Archivo a in ConseguirA(this))
            {
                if (a.seleccionado == true)
                {
                    archivos.Add((a.id, a.Nombre, a.previsual));
                    Controls.Remove(a);
                    archivosL.Remove(a);
                    ResetElementos();
                }
                if (archivos.Count == 1)
                {
                    DialogResult result = MessageBox.Show($"¿Estas seguro que quieres eliminar el archivo {archivos[0].Nombre}?", "Eliminar archivo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            await GoogleInfo.Servicio.Files.Delete(archivos[0].id).ExecuteAsync();
                            var con = await Program.openConnectionAsync();
                            MySqlCommand borrar = new($"update archivo set existencia = false where idarchivo = '{archivos[0].id}'",con);
                            await borrar.ExecuteNonQueryAsync();
                            Program.closeOpenConnection();
                            if (archivos[0].prev != null && archivos[0].prev != "Audio")
                            {
                                await GoogleInfo.Servicio.Files.Delete(archivos[0].prev).ExecuteAsync();
                            }
                        }
                        catch
                        {
                            Program.closeOpenConnection();
                            MessageBox.Show("Ha ocurrido un error al intentar borrar el archivo.", "Error al borrar");
                        }
                    }
                }
                else if (archivos.Count > 0)
                {
                    await EliminarArchivo(archivos);
                }
            }

            
        }

        private async Task EliminarCarpeta(List<(string id, string Nombre)> carpetas)
        {
            List<(string id, string Nombre)> carpetaE = new();
            List<(string id, string Nombre)> archivoE = new();

            foreach (var carpeta in carpetas)
            {
                var contenido = GoogleInfo.Servicio.Files.List();
                contenido.Fields = "files(*)";
                contenido.Q = $"'{carpeta.id}' in parents";

                var request = await contenido.ExecuteAsync();

                foreach (var file in request.Files)
                {
                    if (file.MimeType == "application/vnd.google-apps.folder")
                    {
                        carpetaE.Add((file.Id, file.Name));
                    }
                    else
                    {
                        archivoE.Add((file.Id, file.Name));
                    }
                    await EliminarCarpeta(carpetaE);
                    carpetaE.Clear();
                    await EliminarArchivo(archivoE);
                    archivoE.Clear();
                }

                var con = await Program.openConnectionAsync();
                MySqlCommand borrar = new($"update carpeta set existencia = false where idcarpeta = '{carpeta.id}';", con);
                await borrar.ExecuteNonQueryAsync();
                Program.closeOpenConnection();
            }
           

        }
        private async Task EliminarArchivo(List<(string id, string Nombre)> archivos)
        {
            List<string> excluir = new();
            var con = await Program.openConnectionAsync();
            MySqlCommand prev = new("select imagenPrevisualizacion from archivo;", con);
            MySqlDataReader read = await prev.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                if (!(await read.IsDBNullAsync(0)))
                    excluir.Add(read.GetString(0));
            }
            await read.CloseAsync();

            foreach (var a in archivos)
            {
                try
                {
                    if (!(excluir.Contains(a.id)))
                    {
                        await GoogleInfo.Servicio.Files.Delete(a.id).ExecuteAsync();
                        MySqlCommand borrar = new($"update archivo set existencia = false where idarchivo = '{a.id}'", con);
                        await borrar.ExecuteNonQueryAsync();
                    }
                    Program.closeOpenConnection();
                }
                catch
                {
                    Program.closeOpenConnection();
                    MessageBox.Show("Ha ocurrido un error al intentar borrar el archivo.", "Error al borrar");
                }
            }
        }

        private async Task EliminarArchivo(List<(string id, string Nombre, string prev)> archivos)
        {
            foreach (var a in archivos)
            {
                try
                {
                    await GoogleInfo.Servicio.Files.Delete(a.id).ExecuteAsync();
                    var con = await Program.openConnectionAsync();
                    MySqlCommand borrar = new($"update archivo set existencia = false where idarchivo = '{a.id}'", con);
                    await borrar.ExecuteNonQueryAsync();
                    Program.closeOpenConnection();
                    if (a.prev != null && a.prev != "Audio")
                    {
                        await GoogleInfo.Servicio.Files.Delete(a.prev).ExecuteAsync();
                    }
                }
                catch
                {
                    Program.closeOpenConnection();
                    MessageBox.Show("Ha ocurrido un error al intentar borrar el archivo.", "Error al borrar");
                }
            }
        }

        public static async Task<string> Subir(Carpeta carpeta, string idcarpetapadre, string nombre)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = nombre,
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

        private static async Task<string> SubirPrev(string nombreArch, string parents)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = nombreArch,
                    MimeType = "application/vnd.google-apps.folder",
                    Parents = new List<string>
                    {
                        parents
                    }
                };
                var request = GoogleInfo.Servicio.Files.Create(fileMetadata);
                request.Fields = "id";
                var file = await request.ExecuteAsync();

                return file.Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static async Task Subir(List<string> filePath, Carpeta carpeta, long idproyecto)
        {
            try
            {
                List<string> filtros = new();
                List<string> newCarpeta = new();
                List<string> ordfile = new();
                string month = "";
                string day = "";
                if (DateTime.Now.Month < 10)
                {
                    month = $"0{DateTime.Now.Month}";
                }
                else { month = DateTime.Now.Month.ToString(); }
                if (DateTime.Now.Day < 10)
                {
                    day = $"0{DateTime.Now.Day}";
                }
                else { day = DateTime.Now.Day.ToString(); }

                var con = await Program.openConnectionAsync();
                MySqlCommand cmd = new($"select idcarpeta, filtro from carpeta where idcarpetapadre = '{carpeta.id}'", con);
                MySqlDataReader reader = await cmd.ExecuteReaderAsync();
                
                while (await reader.ReadAsync())
                {
                    if (await reader.IsDBNullAsync(1))
                    {
                        newCarpeta.Add(reader.GetString(0));
                        filtros.Add("null");
                    }
                    else
                    {
                        newCarpeta.Add(reader.GetString(0));
                        filtros.Add(reader.GetString(1));
                    }
                }
                await reader.CloseAsync();
                string consulta = "";
                foreach (string item in filePath)
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
                        request.Fields = "id, name, mimeType, size, parents";
                        await request.UploadAsync();

                        var file = request.ResponseBody;

                        string format = file.MimeType.Split('/')[1];
                        string type = file.MimeType.Split('/')[0];
                        string prevname = file.Name.Split('.')[0];
                        string parent = carpeta.id;

                        for (int i = 0; i < filtros.Count; i++)
                        {
                            string[] filtrar = filtros[i].ToLower().Replace(" ", string.Empty).Split(',');
                            if (newCarpeta[i] != carpeta.id)
                            {
                                if (Array.Exists(filtrar, i => i == file.MimeType))
                                {
                                    FilesResource.UpdateRequest updateRequest = GoogleInfo.Servicio.Files.Update(new Google.Apis.Drive.v3.Data.File(), file.Id);
                                    updateRequest.Fields = "id";
                                    updateRequest.AddParents = newCarpeta[i];
                                    updateRequest.RemoveParents = carpeta.id;
                                    consulta += $"insert into archivo(formato, idarchivo, nombre, size, existencia) values('{format}','{file.Id}','{file.Name}', {file.Size}, true); insert into carga(idusuario, descripcion, idcarpeta, idproyecto, idarchivo, fecha) values('{Program.userId}','s', '{newCarpeta[i]}', {idproyecto}, '{file.Id}','{DateTime.Now.Year}-{month}-{day}'); insert into contiene(idarchivo, idcarpeta) values('{file.Id}','{newCarpeta[i]}'); ";
                                    file = updateRequest.Execute();
                                    ordfile.Add(file.Id);
                                    parent = newCarpeta[i];
                                }
                            }
                        }

                        if (!(ordfile.Contains(file.Id)))
                        {
                            consulta += $"insert into archivo(formato, idarchivo, nombre, size, existencia) values('{format}','{file.Id}','{file.Name}', {file.Size}, true); insert into carga(idusuario, descripcion, idcarpeta, idproyecto, idarchivo, fehca) values('{Program.userId}','s', '{carpeta.id}', {idproyecto}, '{file.Id}','{DateTime.Now.Year}-{month}-{day}'); insert into contiene(idarchivo, idcarpeta) values('{file.Id}','{carpeta.id}'); ";
                            parent = carpeta.id;
                        }

                        if (type == "video")
                        {
                            string idprev = await SubirPrev(prevname, parent);
                        
                            string ffMpegPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\ffmpeg\bin\ffmpeg.exe";
                            var mediaToolkitService = MediaToolkitService.CreateInstance(ffMpegPath);
                            var metadataTask = new FfTaskGetMetadata(item);
                            var metadata = await mediaToolkitService.ExecuteAsync(metadataTask);
                            double duracion = double.Parse(metadata.Metadata.Streams.First().Duration.Replace('.', ','));

                            for (int i = 0; i < 5; i++)
                            {
                                var startInfo = new ProcessStartInfo
                                {
                                    FileName = $@"{AppDomain.CurrentDomain.BaseDirectory}\ffmpeg\bin\ffmpeg.exe",
                                    Arguments = @$"-y -i {item.Replace(" ", "%20")} -an -vf scale=100:-1 -ss {TimeSpan.FromSeconds(duracion * i / 5)} -frames:v 1 PrevVid{i}.png",
                                    CreateNoWindow = true,
                                    UseShellExecute = false,
                                    WorkingDirectory = $@"{AppDomain.CurrentDomain.BaseDirectory}\Subida"
                                };

                                using (var process = Process.Start(startInfo))
                                {
                                    process.Start();
                                    await process.WaitForExitAsync();
                                }

                                var prevFileMD = new Google.Apis.Drive.v3.Data.File()
                                {
                                    Name = $"PrevVid{i}.png",
                                    Parents = new List<string>
                                    {
                                        idprev
                                    }
                                };
                                using (var prevstream = new FileStream($@"{AppDomain.CurrentDomain.BaseDirectory}\Subida\PrevVid{i}.png", FileMode.Open))
                                {
                                    var prevrequest = GoogleInfo.Servicio.Files.Create(prevFileMD, prevstream, "");
                                    await prevrequest.UploadAsync();
                                }

                                if (File.Exists(Path.Combine($@"{AppDomain.CurrentDomain.BaseDirectory}\Subida\", $"PrevVid{i}.png")))
                                {
                                    File.Delete(Path.Combine($@"{AppDomain.CurrentDomain.BaseDirectory}\Subida\", $"PrevVid{i}.png"));
                                }
                            }

                            consulta += $"update archivo set imagenPrevisualizacion = '{idprev}' where idarchivo = '{file.Id}'; ";
                        }
                        else if (type == "image")
                        {
                            string idprev = await SubirPrev(prevname, parent);

                            var startInfo = new ProcessStartInfo
                            {
                                FileName = $@"{AppDomain.CurrentDomain.BaseDirectory}\ffmpeg\bin\ffmpeg.exe",
                                Arguments = @$"-i {item.Replace(" ", "%20")} -vf scale=100:-1 prevImg.png",
                                CreateNoWindow = true,
                                UseShellExecute = false,
                                WorkingDirectory = $@"{AppDomain.CurrentDomain.BaseDirectory}\Subida"
                            };

                            using (var process = Process.Start(startInfo))
                            {
                                process.Start();
                                await process.WaitForExitAsync();
                            }

                            var prevFileMD = new Google.Apis.Drive.v3.Data.File()
                            {
                                Name = "prevImg.png",
                                Parents = new List<string>
                                    {
                                        idprev
                                    }
                            };
                            using (var prevstream = new FileStream($@"{AppDomain.CurrentDomain.BaseDirectory}\Subida\prevImg.png", FileMode.Open))
                            {
                                var prevrequest = GoogleInfo.Servicio.Files.Create(prevFileMD, prevstream, "");
                                await prevrequest.UploadAsync();
                            }

                            if (File.Exists(Path.Combine($@"{AppDomain.CurrentDomain.BaseDirectory}\Subida\", "prevImg.png")))
                            {
                                File.Delete(Path.Combine($@"{AppDomain.CurrentDomain.BaseDirectory}\Subida\", "prevImg.png"));
                            }

                            consulta += $"update archivo set imagenPrevisualizacion = '{idprev}' where idarchivo = '{file.Id}'; ";
                        }
                        else if (type == "audio")
                        {
                            consulta += $"update archivo set imagenPrevisualizacion = 'Audio' where idarchivo = '{file.Id}'; ";
                        }
                    }
                }
                MySqlCommand agregarArch = new(consulta, con);
                await agregarArch.ExecuteNonQueryAsync();
                Program.closeOpenConnection();
            }
            catch (Exception e)
            {
                Program.closeOpenConnection();
                MessageBox.Show(e.Message);
            }
        }

        public static async Task<string> SubirProyecto(Carpeta carpeta, string nombrePro)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = nombrePro,
                    MimeType = "application/vnd.google-apps.folder",
                };
                var request = GoogleInfo.Servicio.Files.Create(fileMetadata);
                request.Fields = "id";
                var file = await request.ExecuteAsync();

                return file.Id;
            }
            catch( Exception e )
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private IEnumerable<Control> ConseguirA(Control control)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in control.Controls)
            {
                controlList.AddRange(ConseguirA(c));
                if (c is Archivo)
                    controlList.Add(c);
            }
            return controlList;
        }

        private IEnumerable<Control> ConseguirC(Control control)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in control.Controls)
            {
                controlList.AddRange(ConseguirC(c));
                if (c is Carpeta)
                    controlList.Add(c);
            }
            return controlList;
        }

        private async Task CargarImagen()
        {
            foreach(Archivo a in ConseguirA(this))
            {
                var prev = GoogleInfo.Servicio.Files.List();
                prev.Fields = "files(id)";
                prev.Q = $"'{a.previsual}' in parents";

                var stream = new MemoryStream();
                var request = await prev.ExecuteAsync();

                if(request != null && request.Files.Count > 0)
                {
                    if(request.Files.Count == 1)
                    {
                        foreach(var file in request.Files)
                        {
                            var desc = GoogleInfo.Servicio.Files.Get(file.Id);

                            await desc.DownloadAsync(stream);

                            if(stream != null)
                            {
                                a.epb.BkgImage = Image.FromStream(stream);
                                if (a.epb.BkgImage.Width > a.epb.BkgImage.Height)
                                {
                                    a.epb.sizeToWidth(a.Width);
                                    a.epb.Location = new(a.Width / 2 - a.epb.Width / 2, 0);
                                }
                                else
                                {
                                    a.epb.sizeToHeight(a.Height - a.lbl.Height);
                                    a.epb.Location = new(a.Width / 2 - a.epb.Width / 2, 0);
                                }
                                a.epb.sizeToHeight(a.Height - a.lbl.Height);
                            }
                        }
                    }
                    else
                    {
                        //Video
                    }
                }
                else
                {
                    if (a.previsual == "Audio")
                    {
                        a.epb.BkgImage = Properties.Resources.Audio;
                        if (a.epb.BkgImage.Width > a.epb.BkgImage.Height)
                        {
                            a.epb.sizeToWidth(a.Width);
                            a.epb.Location = new(a.Width / 2 - a.epb.Width / 2, 0);
                        }
                        else
                        {
                            a.epb.sizeToHeight(a.Height - a.lbl.Height);
                            a.epb.Location = new(a.Width / 2 - a.epb.Width / 2, 0);
                        }
                        a.epb.sizeToHeight(a.Height - a.lbl.Height);
                    }
                }
            }
        }

        public async Task Mover()
        {

        }

        private async void añadirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carpeta carpeta = new Carpeta();
            string month;
            string day;
            if (DateTime.Now.Month < 10)
            {
                month = $"0{DateTime.Now.Month}";
            }
            else { month = DateTime.Now.Month.ToString(); }

            if (DateTime.Now.Day < 10)
            {
                day = $"0{DateTime.Now.Day}";
            }
            else { day = DateTime.Now.Day.ToString(); }
            if (Ruta.proyectoActual != 0)
            {
                var con = await Program.openConnectionAsync();
                try
                {
                    this.Add(carpeta);
                    await carpeta.CambiarNombre();
                    carpeta.id = await Subir(carpeta, Ruta.carpetaActual, carpeta.Nombre);
                    MySqlCommand cmd = new($"insert into carpeta(idcarpeta, idcarpetapadre, idproyecto, nombre, existencia) values('{carpeta.id}','{Ruta.carpetaActual}',{Ruta.proyectoActual},'{carpeta.Nombre}', true); insert into carga(idcarpeta, idusuario, idproyecto, descripcion, fecha) values('{carpeta.id}',{Program.userId},{Ruta.proyectoActual},'c', '{DateTime.Now.Year}-{month}-{day}')", con);
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