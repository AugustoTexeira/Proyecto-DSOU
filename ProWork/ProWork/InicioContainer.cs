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
    public partial class InicioContainer : UserControl
    {
        public InicioContainer()
        {
            InitializeComponent();
            pnl.Anchor = AnchorStyles.Left;
            pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl.Visible = false;
            BackColor = Estilo.fondo;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
            lblProyecto.ForeColor = Estilo.Contraste;
            lblArrastre.ForeColor = Estilo.Contraste;
            pnl.BackColor = Estilo.fondo;
            pnl.ForeColor = Estilo.Contraste;
            uTxtNombreProyecto.BackColor = Estilo.fondo;
            uTxtTipoProyecto.BackColor = Estilo.fondo;
            
        }

        private async void crearbtn_Click(object sender, EventArgs e)
        {
            List<string> lista = new();
            if (pnl.Visible == false)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if( fbd.ShowDialog() == DialogResult.OK)
                {
                    lista.Add(fbd.SelectedPath);

                    if (lista.Count > 0)
                    {
                        lista = getFiles(lista);

                    }

                    pnl.Visible = true;
                }          
            }
            else
            {
                await CrearProyecto(lista);
            }
        }

        private async Task CrearProyecto(List<string> result)
        {
            List<(string desc, string nom, string tipo)> proy = new();
            List<(string nom, string filtro)> carpeta = new();
            string m = "";
            carpeta.Add(("Imagenes", "image/png,image/jpeg"));
            carpeta.Add(("Audio", "audio/mpeg"));
            carpeta.Add(("Video", "video/mp4,video/mkv"));
            carpeta.Add(("Otros", ""));
            foreach (var f in carpeta)
            {
                blsCarpeta.addItem(f.nom, f.filtro);
            }
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
            else { month = DateTime.Now.Day.ToString(); }
            proy.Add((sTxtDescripcion.rtbText, uTxtNombreProyecto.txbText, uTxtTipoProyecto.txbText));
            var con = await Program.openConnectionAsync();
            MySqlCommand pro = new($"insert into proyecto(descripción, tipoProyecto, nombreProyecto, fechaDeCreacion) values('{proy[0].desc}','{proy[0].tipo}','{proy[0].nom}','{DateTime.Now.Year}-{month}-{day}')", con);
            await pro.ExecuteNonQueryAsync();
            Carpeta carpetaC = new();
            MySqlCommand car = new($"insert into carpeta(idcarpeta, nombre, existencia, idproyecto) values('{FileHolder.SubirProyecto(carpetaC, proy[0].nom)}','{carpetaC.Name}', true, {pro.LastInsertedId})", con);
            await car.ExecuteNonQueryAsync();

            string consulta = "";
            foreach (Item a in blsCarpeta.Controls)
            {
                Carpeta hijas = new();
                consulta += $"insert into carpeta(idcarpeta, nombre, existencia, idproyecto, idcarpetapadre) values('{FileHolder.Subir(hijas, carpetaC.id)}','{a.Name}',true,{pro.LastInsertedId},'{carpetaC.id}'); ";
            }

            Program.closeOpenConnection();
            await FileHolder.Subir(result, carpetaC, pro.LastInsertedId);
        }
        private void colorSwap (object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            lblArrastre.ForeColor = Estilo.Contraste;
            lblProyecto.ForeColor = Estilo.Contraste;
        }

        private void InicioContainer_Load(object sender, EventArgs e)
        {
            epbNuevoProyecto.AllowDrop = true;
            this.AllowDrop = true;
        }

        private async void epbNuevoProyecto_DragDrop(object sender, DragEventArgs e)
        {
            List<string> rutas = new();
            foreach (string droppedFile in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (droppedFile.Contains('.'))
                {
                    rutas.Add(droppedFile);
                }
                else
                {
                    rutas.AddRange(getFiles(Directory.GetDirectories(droppedFile).ToList()));
                    rutas.AddRange(Directory.GetFiles(droppedFile).ToList());
                }
            }
            lblProyecto.AllowDrop = false;
            await CrearProyecto(rutas);
        }
        private List<string> getFiles(List<string> ss)
        {
            if (ss.Count == 0)
            {
                return new();
            }
            else
            {
                List<string> sss = new();
                foreach (string s in ss)
                {
                    sss.AddRange(getFiles(Directory.GetDirectories(s).ToList()));
                    sss.AddRange(Directory.GetFiles(s).ToList());
                }
                return sss;
            }
        }

        private void epbNuevoProyecto_DragDropEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Filtrado(object sender, string filtro)
        {
            foreach (Item a in blsCarpeta.Controls)
            {
                if(a.Text == ((frmCarpetaConf)sender).name && ((frmCarpetaConf)sender).filtro == a.varcharId)
                {
                    a.varcharId = filtro;
                }
            }
        }
        private void pnl_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void customButton2_ButtonClick(object sender, EventArgs e)
        {
            blsCarpeta.addItem("Nueva carpeta", "");
        }

        private void blsCarpeta_gearClicked(object sender, EventArgs e)
        {
            frmCarpetaConf config = new(((Item)sender).varcharId,((Item)sender).Text);
            config.Show();
            config.Filtrar += Filtrado;
        }
    }
}
