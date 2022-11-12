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
    public partial class frmAñadirContacto : Form
    {
        MySqlCommand cmd;
        public frmAñadirContacto()
        {
            InitializeComponent();
        }

        private async void cbtAniadir_ButtonClick(object sender, EventArgs e)
        {
            await Program.waitForOpenConnection();
            if(utbNombre.txbText != "" && utbCorreo.txbText.Contains('@'))
            {
                cmd = new($"select correoElectronico from contacto", Program.connection);

                MySqlDataReader reader = await cmd.ExecuteReaderAsync();

                bool v = true;

                while (await reader.ReadAsync())
                {
                    if (utbCorreo.txbText == reader.GetString(0))
                    {
                        v = false;
                        break;
                    }
                }
                await reader.CloseAsync();

                if(!v)
                {
                    MessageBox.Show("El contacto debe tener un correo electrónico válido.");
                    return;
                }

                cmd = new($"insert into contacto(correoElectronico, nombre, número, descripción) values('{utbCorreo.txbText}', '{utbNombre.txbText}', '{utbTel.txbText}', '{stbDesc.rtbText}')", Program.connection);
                await cmd.ExecuteNonQueryAsync();
                CambioExitoso.Invoke(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("El contacto debe tener nombre y un correo electrónico válido.");
            }
        }
        private void frmAñadirContacto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            Dispose();
        }
        public event EventHandler CambioExitoso;
    }
}
