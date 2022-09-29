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
using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class frmTinyLogin : Form
    {
        private MySqlConnection connection;
        public frmTinyLogin()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
        }
        public frmTinyLogin(MySqlConnection con)
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
            lblRegistrarme.ForeColor = Estilo.Contraste;
            connection = con;
        }

        private void cbtCrear_Click(object sender, EventArgs e)
        {
            utbNombre.Enabled = false;
            utbContra.Enabled = false;

            if(!bgwCheck.IsBusy)
            {
                bgwCheck.RunWorkerAsync();
            }
        }

        private void bgwCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!connection.Ping())
                {
                    connection.Open();
                }
                MySqlCommand vLogin = new("select nombre, password, administrador from usuario where password=sha2('" + utbContra.txbText + "', 224);", connection);
                MySqlDataReader reader = vLogin.ExecuteReader();

                bool v = false;
                bool admin = false;

                while (reader.Read())
                {
                    if (utbNombre.txbText == reader.GetString(0))
                    {
                        v = true;
                        admin = reader.GetBoolean(2);
                    }
                }

                reader.Close();

                if (v)
                {
                    e.Result = new frmPruebaa();
                    //e.Result = new frmMain(utbNombre.txbText, admin);
                }
                else
                {
                    MessageBox.Show("No existe cuenta con tal nombre y contraseña.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n Ingrese algo correcto.");
            }
        }

        private void bgwCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            utbNombre.Enabled = true;
            utbContra.Enabled = true;

            if (e.Result != null)
            {
                frmPruebaa main = (frmPruebaa)e.Result;
                main.Show();
                this.Close();
            }
        }

        private void frmTinyRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }

        private void btnContra_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new(Estilo.fondo, (int)(Estilo.medioAnchoLinea * 1.5));

            if (utbContra.UsePasswordChar)
            {
                pen.Color = Estilo.Contraste;

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnContra.Height - 5, btnContra.Width - 5, 5);
            }
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            utbContra.UsePasswordChar = !utbContra.UsePasswordChar;
            btnContra.Refresh();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.Font = new(lblLogin.Font, FontStyle.Underline);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.Font = new(lblLogin.Font, FontStyle.Regular);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmTinyRegister registro = new frmTinyRegister(connection);
            registro.Show();
            this.Close();
        }
    }
}
