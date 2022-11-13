using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace ProWork
{
    public partial class frmTinyRegister : Form
    {
        private int yContra;
        private int xPlus;
        public frmTinyRegister()
        {
            InitializeComponent();
            yContra = utbContra.Location.Y;
            xPlus = pbPlusUser.Location.X;
            this.BackColor = Estilo.fondo;
            this.BackColor = Estilo.fondo;
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
            if (utbCContra.Visible) // Registro
            {
                if (utbCContra.txbText == utbContra.txbText && utbNombre.txbText != "")
                {
                    try
                    {
                        var con = Program.openConnection();
                        MySqlCommand vRegistro = new("select nombre from usuario;", con);
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
                            MySqlCommand iRegistro = new("insert into usuario (nombre, password, administrador) " +
                                                        "values ('" + utbNombre.txbText + "', sha2('" + utbContra.txbText + "', 224), false);",
                                                        con
                                                        );
                            iRegistro.ExecuteNonQuery();
                            Program.userAdmin = false;
                            Program.user = utbNombre.txbText;
                            e.Result = true;
                            //e.Result = new frmMain(utbNombre.txbText, false);
                        }
                        else
                        {
                            MessageBox.Show("La cuenta ya existe.");
                        }
                        Program.closeOpenConnection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + "\n Ingrese algo correcto.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos apropiadamente.");
                }
            }
            else //Login
            {
                try
                {
                    var con = Program.openConnection();
                    MySqlCommand vLogin = new("select nombre, password, administrador from usuario where password=sha2('" + utbContra.txbText + "', 224);", con);
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

                    if (v)
                    {
                        Program.userAdmin = admin;
                        Program.user = utbNombre.txbText;
                        e.Result = true;
                    }
                    else
                    {
                        MessageBox.Show("No existe cuenta con tal nombre y contraseña.");
                    }
                    reader.Close();
                    Program.closeOpenConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\n Ingrese algo correcto.");
                }
            }
        }

        private void bgwCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            utbNombre.Enabled = true;
            utbContra.Enabled = true;
            utbCContra.Enabled = true;

            if (e.Result != null)
            {
                frmMain main = new();
                main.Show();
                this.Close();
            }
        }

        private void frmTinyRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            Dispose();
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
            if (utbCContra.Visible)
            {
                tmrIntoRegister.Stop();
                tmrIntoLogin.Start();
            }
            else
            {
                pbPlusUser.Visible = true;
                utbCContra.Visible = true;
                tmrIntoLogin.Stop();
                tmrIntoRegister.Start();
            }
        }

        private void tmrIntoRegister_Tick(object sender, EventArgs e)
        {
            if (utbContra.Location.Y >= yContra)
            {
                utbCContra.Visible = true;

                int cambio = (yContra - utbContra.Location.Y) / 4 - 1;

                utbNombre.Location = new Point(utbNombre.Location.X, utbNombre.Location.Y + cambio);
                utbContra.Location = new Point(utbContra.Location.X, utbContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);
            }
            else if (utbCContra.Location.X >= utbContra.Location.X)
            {
                int cambio = (utbContra.Location.X - utbCContra.Location.X) / 2 - 1;

                utbCContra.Location = new Point(utbCContra.Location.X + cambio, utbCContra.Location.Y);

                cambio = (xPlus - pbPlusUser.Location.X) / 2 - 1;

                pbPlusUser.Location = new Point(pbPlusUser.Location.X + cambio, pbPlusUser.Location.Y);
            }
            else
            {
                cbtCrear.Texto = "Crear";
                lblLogin.Text = "¿Tienes una cuenta? Inicia sesión";
                this.Text = "Registrarme";
                tmrIntoRegister.Stop();
            }
        }

        private void tmrIntoLogin_Tick(object sender, EventArgs e)
        {
            if (utbCContra.Location.X < this.Width)
            {
                int cambio = (this.Width - utbCContra.Location.X) / 2 + 1;

                utbCContra.Location = new Point(utbCContra.Location.X + cambio, utbCContra.Location.Y);

                cambio = (this.Width - pbPlusUser.Location.X) / 2 + 1;

                pbPlusUser.Location = new Point(pbPlusUser.Location.X + cambio / 2, pbPlusUser.Location.Y);
            }
            else if (utbContra.Location.Y <= utbCContra.Location.Y)
            {
                int cambio = (utbCContra.Location.Y - utbContra.Location.Y) / 4 + 1;

                utbNombre.Location = new Point(utbNombre.Location.X, utbNombre.Location.Y + cambio);
                utbContra.Location = new Point(utbContra.Location.X, utbContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);
            }
            else
            {
                cbtCrear.Texto = "Ingresar";
                lblLogin.Text = "¿No tienes una cuenta? Regístrate";
                this.Text = "Iniciar sesión";
                utbCContra.Visible = false;
                pbPlusUser.Visible = false;
                tmrIntoLogin.Stop();
            }
        }
    }
}
