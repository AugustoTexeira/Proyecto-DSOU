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
    public partial class Ruta : UserControl
    {
        public static string carpetaActual = "";
        public static int proyectoActual = 0;
        public Ruta()
        {
            InitializeComponent();
        }
        public async void DefinirRuta(object sender)
        {
            if (sender != null)
            {
                var con = await Program.openConnectionAsync();
                MySqlCommand cmd = new MySqlCommand($"WITH RECURSIVE consulta AS ( SELECT C.idcarpeta, C.idcarpetaPadre, C.nombre, C.idproyecto, null FROM Carpeta AS C WHERE idcarpeta = '{sender}' UNION SELECT c.idcarpeta, c.idcarpetaPadre, c.nombre, c.idproyecto, null FROM consulta INNER JOIN Carpeta AS c ON consulta.idcarpetaPadre = c.idcarpeta )SELECT * FROM consulta UNION select null, null, null, idproyecto, idcarpeta from carpeta where idcarpeta = '{sender}';", con);
                MySqlDataReader reader = await cmd.ExecuteReaderAsync();
                this.Controls.Clear();

                while (await reader.ReadAsync())
                {
                    if (await reader.IsDBNullAsync(0))
                    {
                        Ruta.carpetaActual = reader.GetString(4);
                        Ruta.proyectoActual = reader.GetInt32(3);
                    }
                    else
                    {
                        lblRuta lbl = new lblRuta(reader.GetString(0), $"/{reader.GetString(2)}");
                        lbl.Dock = DockStyle.Left;
                        lbl.Font = this.Font;
                        lbl.ForeColor = Estilo.Contraste;
                        lbl.Click += lbl_OnClick;
                        lbl.AutoSize = false;
                        lbl.Height = this.Height;
                        lbl.Width = TextRenderer.MeasureText(lbl.Text, lbl.Font).Width;
                        this.Controls.Add(lbl);
                    }
                }
                await reader.CloseAsync();
                Program.closeOpenConnection();
            }
            else
            {
                this.Controls.Clear();
            }

            lblRuta lbl1 = new("0", "ProWork");
            lbl1.Dock = DockStyle.Left;
            lbl1.Font = this.Font;
            lbl1.ForeColor = Estilo.Contraste;
            lbl1.Click += lbl_OnClick;
            lbl1.AutoSize = false;
            lbl1.Height = this.Height;
            lbl1.Width = TextRenderer.MeasureText(lbl1.Text, lbl1.Font).Width;
            this.Controls.Add(lbl1);
        }

        private void Ruta_FontChanged(object sender, EventArgs e)
        {
            this.Height = this.Font.Height;
        }

        private void lbl_OnClick(object sender, EventArgs e)
        {
            Clack.Invoke(((lblRuta)sender).id, null);
        }

        public event EventHandler Clack;

        private void Ruta_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
        }
    }

    public class lblRuta : Label
    {
        public string id;
        public lblRuta(string id, string nom)
        {
            this.id = id;
            this.Text = nom;
            BackColor = Estilo.fondo;
            ForeColor = Estilo.Contraste;

            De_Configuración__Cristian_.ConfigContainer.ColorSwap += colorSwap;
        }
        private void colorSwap(object sender, EventArgs e)
        {
            this.BackColor = Estilo.fondo;
            this.ForeColor = Estilo.Contraste;
        }

        private void onEnter()
        {
            
        }
    }
}
