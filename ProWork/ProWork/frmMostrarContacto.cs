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
    public partial class frmMostrarContacto : Form
    {
        public frmMostrarContacto(int id, string nombre, MySqlDataReader rdr)
        {
            InitializeComponent();
            MySqlDataReader reader = rdr;
            reader.Read();

            lblEmail.Text = reader.GetString(0);
            lblTel.Text = reader.GetString(1);
            if(!reader.IsDBNull(2))
            {
                rtb.Text = reader.GetString(2);
            }

            reader.Close();

            this.Text = $"Información del contacto {nombre}";
            lblNombre.Text = nombre;

            BackColor = Estilo.fondo;
            lblNombre.BackColor = Estilo.fondo;
            lblNombre.ForeColor = Estilo.Contraste;
            rtb.BackColor = Estilo.fondo;
            rtb.ForeColor = Estilo.Contraste;

            lblEmail.ForeColor = Estilo.Contraste;
            lblEmail.LinkColor = Estilo.Contraste;
            lblEmail.DisabledLinkColor = Estilo.Contraste;
            lblEmail.ActiveLinkColor = Estilo.Contraste;
            lblEmail.VisitedLinkColor = Estilo.Contraste;

            lblTel.ForeColor = Estilo.Contraste;
            lblTel.LinkColor = Estilo.Contraste;
            lblTel.DisabledLinkColor = Estilo.Contraste;
            lblTel.ActiveLinkColor = Estilo.Contraste;
            lblTel.VisitedLinkColor = Estilo.Contraste;

            if (Estilo.fondo == Color.White)
            {
                epb.BkgImage = Properties.Resources.ContactoModoClaro;
            }
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += swapColor;
        }

        private void swapColor (object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            lblNombre.BackColor = Estilo.fondo;
            lblNombre.ForeColor = Estilo.Contraste;
            rtb.BackColor = Estilo.fondo;
            rtb.ForeColor = Estilo.Contraste;

            lblEmail.ForeColor = Estilo.Contraste;
            lblEmail.LinkColor = Estilo.Contraste;
            lblEmail.DisabledLinkColor = Estilo.Contraste;
            lblEmail.ActiveLinkColor = Estilo.Contraste;
            lblEmail.VisitedLinkColor = Estilo.Contraste;

            lblTel.ForeColor = Estilo.Contraste;
            lblTel.LinkColor = Estilo.Contraste;
            lblTel.DisabledLinkColor = Estilo.Contraste;
            lblTel.ActiveLinkColor = Estilo.Contraste;
            lblTel.VisitedLinkColor = Estilo.Contraste;
            if ((bool)sender)
            {
                epb.BkgImage = Properties.Resources.ContactoModoClaro;
            }
            else
            {
                epb.BkgImage = Properties.Resources.ContactoOscuro;
            }
        }

        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmMostrarContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            Dispose();
        }
    }
}
