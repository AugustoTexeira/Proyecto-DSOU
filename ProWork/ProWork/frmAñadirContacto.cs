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
            if(utbNombre.txbText != "")
            {
                if(!bgwConfirmar.IsBusy)
                {
                    cmd = new($"insert into contacto(correoElectronico, nombre, número, descripcion) values('{utbCorreo.txbText}', '{utbNombre.txbText}', '{utbTel.txbText}', '{stbDesc.rtbText}')", Program.connection);
                    bgwConfirmar.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("El contacto debe tener nombre.");
            }
        }

        private void bgwConfirmar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void frmAñadirContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }
    }
}
