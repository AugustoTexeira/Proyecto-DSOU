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
    public partial class frmContactosConfig : Form
    {
        private int id;
        public frmContactosConfig(int id, string nombre, MySqlDataReader rdr)
        {
            InitializeComponent();

            MySqlDataReader reader = rdr;
            
            reader.Read();

            this.Text = $"Configuración del contacto {nombre}";
            this.BackColor = Estilo.fondo;
            txbNombre.BackColor = Estilo.fondo;
            txbNombre.Text = nombre;
            utbEmail.txbText = reader.GetString(0);
            utbTel.txbText = reader.GetString(1);
            if(!reader.IsDBNull(2))
            {
                stbDesc.rtbText = reader.GetString(2);
            }
            this.id = id;

            reader.Close();
        }

        public event EventHandler CambioExitoso;

        private async void cbtGuardar_ButtonClick(object sender, EventArgs e)
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show("El contacto debe tener nombre.");
                return;
            }
            if (txbNombre.Text.Length > 30 || utbTel.txbText.Length > 30)
            {
                MessageBox.Show("El nombre y/o teléfono del contacto no puede exeder treinta caracteres.");
                return;
            }
            if  (utbEmail.txbText.Length > 254)
            {
                MessageBox.Show("El nombre y/o teléfono del contacto no puede exeder treinta caracteres.");
                return;
            }
            var con = await Program.openConnectionAsync();
            MySqlCommand cmd = new($"update contacto set correoElectronico='{utbEmail.txbText}', nombre='{txbNombre.Text}', número='{utbTel.txbText}', descripción='{stbDesc.rtbText}' where idcontacto={id}", con);
            cmd.ExecuteNonQuery();
            CambioExitoso.Invoke(txbNombre.Text, e);
            Program.closeOpenConnection();
            this.Close();
        }

        private void frmContactosConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }
    }
}
