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
    public partial class frmAñadirContacto : Form
    {
        MySqlCommand cmd;
        public frmAñadirContacto()
        {
            InitializeComponent();
        }

        private void bgwConfirmar_DoWork(object sender, DoWorkEventArgs e)
        {
            Program.tryToConnect();
            cmd.ExecuteNonQuery();
        }

        private void cbtAniadir_ButtonClick(object sender, EventArgs e)
        {
            if(utbNombre.txbText != "" && utbCorreo.txbText.Contains('@'))
            {
                Program.tryToConnect();
                cmd = new($"select correoElectronico from contacto", Program.connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                bool v = true;

                while (reader.Read())
                {
                    if (utbCorreo.txbText == reader.GetString(0))
                    {
                        v = false;
                        break;
                    }
                }
                reader.Close();

                if(!v)
                {
                    MessageBox.Show("El contacto debe tener un correo electrónico válido.");
                    return;
                }

                if (!bgwConfirmar.IsBusy)
                {
                    cmd = new($"insert into contacto(correoElectronico, nombre, número, descripcion) values('{utbCorreo.txbText}', '{utbNombre.txbText}', '{utbTel.txbText}', '{stbDesc.rtbText}')", Program.connection);
                    bgwConfirmar.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("El contacto debe tener nombre y un correo electrónico válido.");
            }
        }

        private void bgwConfirmar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CambioExitoso.Invoke(sender, e);
            this.Close();
        }

        private void frmAñadirContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }
        public event EventHandler CambioExitoso;
    }
}
