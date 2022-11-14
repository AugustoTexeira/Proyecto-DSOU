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
    public partial class Archivo : UserControl
    {
        public string Nombre
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }
        public string id;
        public bool seleccionado = false;
        public Archivo(Image imagen)
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            lbl.ForeColor = Estilo.Contraste;
            epb.BackColor = Estilo.fondo;
        }

        public event EventHandler Eliminar;
        public event EventHandler Deseleccionar;
        public event EventHandler DescargarCarpeta;
        public Archivo()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            lbl.ForeColor = Estilo.Contraste;
            epb.BackColor = Estilo.fondo;
            if (epb.BkgImage.Width > epb.BkgImage.Height)
            {
                epb.sizeToWidth(Width);
                epb.Location = new(0, 0);
            }
            else
            {
                epb.sizeToHeight(Height - lbl.Height);
                epb.Location = new(0, 0);
            }
            epb.sizeToHeight(Height - lbl.Height);
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seleccionado == true)
            {
                DescargarCarpeta.Invoke(this, e);
            }
            else
            {
                MessageBox.Show("Seleccione la carpeta correctamente.");
            }
        }

        private void Carpeta_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    seleccionado = true;
                    this.BackColor = Color.FromArgb(20, Estilo.enfasis);
                }
                else
                {
                    Deseleccionar.Invoke(this, e);
                    this.BackColor = Estilo.fondo;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(this, new Point(e.Location.X + ((Control)sender).Location.X, e.Location.Y + ((Control)sender).Location.Y));
            }
        }
    }
}
