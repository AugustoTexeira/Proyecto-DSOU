using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProWork
{
    public partial class frmMostrarContacto : Form
    {
        public frmMostrarContacto(int id, string nombre)
        {
            InitializeComponent();
            Program.tryToConnect();
            MySqlCommand cmd = new MySqlCommand($"select correoElectronico, número, descripcion from contacto where idcontacto={id}", Program.connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            lblEmail.Text = reader.GetString(0);
            lblTel.Text = reader.GetString(1);
            rtb.Text = reader.GetString(2);

            reader.Close();

            this.Text = $"Configuración del contacto {nombre}";
            lblNombre.Text = nombre;
            this.BackColor = Estilo.fondo;
            lblNombre.BackColor = Estilo.fondo;
            rtb.BackColor = Estilo.fondo;
            lblEmail.ForeColor = Estilo.Contraste;
            lblNombre.ForeColor = Estilo.Contraste;
            lblTel.ForeColor = Estilo.Contraste;
        }

        private void rtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
