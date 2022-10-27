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
    public partial class frmAccConfig : Form
    {
        public frmAccConfig()
        {
            InitializeComponent();
        }
        public frmAccConfig(string user)
        {
            InitializeComponent();
            this.Text = "⚙️ Configuración: " + user;
            utbNombre.PlaceholderText = user;
            utbContra.PlaceholderText = "Vacío: Contraseña anterior";
            utbCContra.PlaceholderText = "Vacío: Contraseña anterior";
        }

        private void cbtGuardar_Click(object sender, EventArgs e)
        {
            if (utbCContra.txbText == utbContra.txbText)
            {
                Program.tryToConnect();
                if (utbNombre.txbText != "" && utbContra.txbText != "")
                {
                    MySqlCommand cmd = new($"update usuario set nombre='{utbNombre.txbText}', password=sha2('{utbContra.txbText}', 224) where nombre='{utbNombre.PlaceholderText}';", Program.connection);
                    cmd.ExecuteNonQuery();
                    CambioExitoso.Invoke(utbNombre.txbText, e);
                    this.Close();
                }
                else
                {
                    if (utbNombre.txbText != "")
                    {
                        MySqlCommand cmd = new($"update usuario set nombre='{utbNombre.txbText}' where nombre='{utbNombre.PlaceholderText}';", Program.connection);
                        cmd.ExecuteNonQuery();

                        CambioExitoso.Invoke(utbNombre.txbText, e);
                        this.Close();
                    }
                    else
                    {
                        if (utbContra.txbText != "")
                        {
                            MySqlCommand cmd = new($"update usuario set password=sha2('{utbContra.txbText}', 224) where nombre='{utbNombre.PlaceholderText}';", Program.connection);
                            cmd.ExecuteNonQuery();

                            CambioExitoso.Invoke(null, e);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe completar algún campo para realizar cambios.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Las constraseñas deben coincidir.");
            }
        }
        public event EventHandler CambioExitoso; //Si se cambia el nombre es el object, sino el object es null.

        private void frmAccConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }
    }
}
