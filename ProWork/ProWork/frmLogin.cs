using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ProWork
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprowork; Uid=root; Pwd=;");
        //Paleta de colores
        public Color enfasis = Color.Blue;
        public Color contraste = Color.White;
        public Color fondoprincipal = Color.DarkBlue;
        /* 
         Nomenclatura:
            txb = TextBox
            ctb = UnderlinedTextBox
            btn = Button
            pbx = PictureBox
            frm = Form
        */
        /*
         Bugs a arreglar:
            - Hay sobrelapado en las animaciones de IntoLogin/Register.
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
                if (ctbCContra.Text == ctbContra.Text && ctbNombre.Text != "")
                {
                    try
                    {
                        MySqlCommand vRegistro = new("select nombre from usuario;", conexion);
                        MySqlDataReader reader = vRegistro.ExecuteReader();

                        bool v = true;
                        
                        while (reader.Read())
                        {
                            if (ctbNombre.Text == reader.GetString(0))
                            {
                                v = false;
                            }
                        }

                        if (v)
                        {
                            MySqlCommand iRegistro = new("insert into usuarios (nombre, contrasenia, administrador) " +
                                                        "values('" + ctbNombre.Text + "', sha2('" + ctbContra.Text + "', 224), false);",
                                                        conexion
                                                        );
                            e.Result = new frmMain(ctbNombre.Text, false);
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
                    MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprowork; Uid=root; Pwd=;");
                    conexion.Open();
                    MySqlCommand vLogin = new("select nombre, contrasenia, administrador from usuario where contrasenia=sha2('" +ctbContra.Text + "', 224);", conexion);
                    MySqlDataReader reader = vLogin.ExecuteReader();

                    bool v = false;
                    bool admin = false;

                    while (reader.Read())
                    {
                        if (ctbNombre.Text == reader.GetString(0))
                        {
                            v = true;
                            admin = reader.GetBoolean(2);
                        }
                    }

                    if (v)
                    {
                        e.Result = new frmMain(ctbNombre.Text, admin);
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
                Pen pen = new(contraste, 3);

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
                Pen pen = new(contraste, 3);

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
                frmMain main = (frmMain)e.Result;
                main.Show();
                this.Hide();
            }
        }
    }
}