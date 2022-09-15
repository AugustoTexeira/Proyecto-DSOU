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
    public partial class frmTinyRegister : Form
    {
        private MySqlConnection connection;
        public frmTinyRegister()
        {
            InitializeComponent();
            this.BackColor = Estilo.fondo;
        }
        public frmTinyRegister(MySqlConnection con)
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
            utbCContra.Enabled = false;

            if (!bgwCheck.IsBusy)
            {
                bgwCheck.RunWorkerAsync();
            }
        }

        private void bgwCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            if (utbCContra.txbText == utbContra.txbText && utbNombre.txbText != "")
            {
                try
                {
                    MySqlCommand vRegistro = new("select nombre from usuario;", connection);
                    MySqlDataReader reader = vRegistro.ExecuteReader();

                    bool v = true;

                    while (reader.Read())
                    {
                        if (utbNombre.txbText == reader.GetString(0))
                        {
                            v = false;
                        }
                    }
                    reader.Close();
                    if (v)
                    {
                        MySqlCommand iRegistro = new("insert into usuario (nombre, contrasenia, administrador) " +
                                                    "values ('" + utbNombre.txbText + "', sha2('" + utbContra.txbText + "', 224), false);",
                                                    connection
                                                    );
                        iRegistro.ExecuteNonQuery();
                        //e.Result = new frmMain(utbNombre.txbText, false);
                        e.Result = new frmPruebaa();
                    }
                    else
                    {
                        MessageBox.Show("La cuenta ya existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\n\nIngrese algo correcto.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos apropiadamente.");
            }
        }

        private void bgwCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            utbNombre.Enabled = true;
            utbContra.Enabled = true;
            utbCContra.Enabled = true;

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

        private void btnCContra_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new(Estilo.fondo, (int)(Estilo.medioAnchoLinea * 1.5));

            if (utbCContra.UsePasswordChar)
            {
                pen.Color = Estilo.Contraste;

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnCContra.Height - 5, btnCContra.Width - 5, 5);
            }
        }

        private void btnCContra_Click(object sender, EventArgs e)
        {
            utbCContra.UsePasswordChar = !utbCContra.UsePasswordChar;
            btnCContra.Refresh();
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
            frmTinyLogin login = new(connection);
            login.Show();
            this.Close();
        }
    }
}
