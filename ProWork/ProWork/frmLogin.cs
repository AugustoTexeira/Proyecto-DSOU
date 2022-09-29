using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProWork
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=prowork; Uid=root; Pwd=;");
        /* 
         Nomenclatura:
            txb = TextBox
            ctb = UnderlinedTextBox
            btn = Button
            pbx = PictureBox
            frm = Form
        */
        //Felxibilidad
        private int yContra;
        private int xPlus;

        public frmLogin()
        {
            InitializeComponent();
            yContra = ctbContra.Location.Y;
            xPlus = pbPlusUser.Location.X;
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                if (ex != null) { MessageBox.Show("No se pudo establecer conexión."); }
            }
        }

        private void pbxOContra_Click(object sender, EventArgs e)
        {
            ctbContra.UsePasswordChar = !ctbContra.UsePasswordChar;
            btnContra.Refresh();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ctbNombre.Enabled = false;
            ctbContra.Enabled = false;
            ctbCContra.Enabled = false;

            bgwCheck.RunWorkerAsync();
        }
        private void checkLogin(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (ctbCContra.Visible) // Registro
            {
                if (ctbCContra.txbText == ctbContra.txbText && ctbNombre.txbText != "")
                {
                    try
                    {
                        MySqlCommand vRegistro = new("select nombre from usuario;", conexion);
                        MySqlDataReader reader = vRegistro.ExecuteReader();

                        bool v = true;
                        
                        while (reader.Read())
                        {
                            if (ctbNombre.txbText == reader.GetString(0))
                            {
                                v = false;
                            }
                        }
                        reader.Close();
                        if (v)
                        {
                            MySqlCommand iRegistro = new("insert into usuario (nombre, password, administrador) " +
                                                        "values ('" + ctbNombre.txbText + "', sha2('" + ctbContra.txbText + "', 224), false);",
                                                        conexion
                                                        );
                            iRegistro.ExecuteNonQuery();
                            e.Result = new frmPruebaa(conexion, ctbNombre.txbText, false);
                            //e.Result = new frmMain(ctbNombre.txbText, false);
                        }
                        else
                        {
                            MessageBox.Show("La cuenta ya existe.");
                        }
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
                    if (!conexion.Ping())
                    {
                        conexion.Open();
                    }
                    MySqlCommand vLogin = new("select nombre, password, administrador from usuario where password=sha2('" +ctbContra.txbText + "', 224);", conexion);
                    MySqlDataReader reader = vLogin.ExecuteReader();

                    bool v = false;
                    bool admin = false;

                    while (reader.Read())
                    {
                        if (ctbNombre.txbText == reader.GetString(0))
                        {
                            v = true;
                            admin = reader.GetBoolean(2);
                        }
                    }

                    reader.Close();

                    if (v)
                    {
                        e.Result = new frmPruebaa(conexion, ctbNombre.txbText, admin);
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
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (ctbCContra.Visible)
            {
                tmrIntoRegister.Stop();
                tmrIntoLogin.Start();
            }
            else
            {
                pbPlusUser.Visible = true;
                ctbCContra.Visible = true;
                btnCContra.Visible = true;
                tmrIntoLogin.Stop();
                tmrIntoRegister.Start();
            }
        }

        private void btnContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (ctbContra.UsePasswordChar)
            {
                Pen pen = new(Estilo.Contraste, 3);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnContra.Height - 5, btnContra.Width - 5, 5);
            }
        }

        private void btnCContra_Click(object sender, EventArgs e)
        {
            ctbCContra.UsePasswordChar = !ctbCContra.UsePasswordChar;
            btnCContra.Refresh();
        }

        private void btnCContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (ctbCContra.UsePasswordChar)
            {
                Pen pen = new(Estilo.Contraste, 3);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnCContra.Height - 5, btnCContra.Width - 5, 5);
            }
        }

        private void tmrIntoLogin_Tick(object sender, EventArgs e)
        {
            if (ctbCContra.Location.X < this.Width)
            {
                int cambio = (this.Width - ctbCContra.Location.X) / 2 + 1;

                ctbCContra.Location = new Point(ctbCContra.Location.X + cambio, ctbCContra.Location.Y);
                btnCContra.Location = new Point(btnCContra.Location.X + cambio, btnCContra.Location.Y);

                cambio = (this.Width - pbPlusUser.Location.X) / 2 + 1;

                pbPlusUser.Location = new Point(pbPlusUser.Location.X + cambio / 2, pbPlusUser.Location.Y);
            }
            else if (ctbContra.Location.Y <= ctbCContra.Location.Y)
            {
                int cambio = (ctbCContra.Location.Y - ctbContra.Location.Y) / 4 + 1;

                ctbNombre.Location = new Point(ctbNombre.Location.X, ctbNombre.Location.Y + cambio);
                ctbContra.Location = new Point(ctbContra.Location.X, ctbContra.Location.Y + cambio);
                btnContra.Location = new Point(btnContra.Location.X, btnContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);
            }
            else
            {
                btnLogin.Texto = "Ingresar";
                btnSwap.Text = "¿No tienes una cuenta? Regístrate";
                ctbCContra.Visible = false;
                btnCContra.Visible = false;
                pbPlusUser.Visible = false;
                tmrIntoLogin.Stop();
            }
        }

        private void tmrIntoRegister_Tick(object sender, EventArgs e)
        {
            if (ctbContra.Location.Y >= yContra)
            {
                ctbCContra.Visible = true;
                btnContra.Visible = true;

                int cambio = (yContra - ctbContra.Location.Y) / 4 - 1;

                ctbNombre.Location = new Point(ctbNombre.Location.X, ctbNombre.Location.Y + cambio);
                ctbContra.Location = new Point(ctbContra.Location.X, ctbContra.Location.Y + cambio);
                btnContra.Location = new Point(btnContra.Location.X, btnContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);
            }
            else if (ctbCContra.Location.X >= ctbContra.Location.X)
            {
                int cambio = (ctbContra.Location.X - ctbCContra.Location.X) / 2 - 1;

                ctbCContra.Location = new Point(ctbCContra.Location.X + cambio, ctbCContra.Location.Y);
                btnCContra.Location = new Point(btnCContra.Location.X + cambio, btnCContra.Location.Y);

                cambio = (xPlus - pbPlusUser.Location.X) / 2 - 1;

                pbPlusUser.Location = new Point(pbPlusUser.Location.X + cambio, pbPlusUser.Location.Y);
            }
            else
            {
                btnLogin.Texto = "Crear";
                btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
                tmrIntoRegister.Stop();
            }
        }

        private void bgwCheck_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ctbNombre.Enabled = true;
            ctbContra.Enabled = true;
            ctbCContra.Enabled = true;

            if(e.Result != null)
            {
                frmPruebaa main = (frmPruebaa)e.Result;
                main.Show();
                this.Close();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
        }
    }
}