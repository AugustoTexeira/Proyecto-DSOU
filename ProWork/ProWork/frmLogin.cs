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
            ctb = CustomTextBox(Con doble buffering)
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

        //Procesos

        decimal largo = 1; //Porcentaje de progreso de énfasis. 1 = 100%
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

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (ctbNombre.Focused)
            {
                subrayar(ctbNombre, e, largo);
                subrayar(ctbContra, e);
                subrayar(ctbCContra, e);
            }
            else if (ctbContra.Focused)
            {
                subrayar(ctbNombre, e);
                subrayar(ctbContra, e, largo);
                subrayar(ctbCContra, e);
            }
            else if (ctbCContra.Focused)
            {
                subrayar(ctbNombre, e);
                subrayar(ctbContra, e);
                subrayar(ctbCContra, e, largo);
            }
            else if (ctbCContra.Visible)
            {
                subrayar(ctbNombre, e);
                subrayar(ctbContra, e);
                subrayar(ctbCContra, e);
            }
            else
            {
                subrayar(ctbNombre, e);
                subrayar(ctbContra, e);
            }
        }

        private void pbxOContra_Click(object sender, EventArgs e)
        {
            ctbContra.UseSystemPasswordChar = !ctbContra.UseSystemPasswordChar;
            btnContra.Refresh();
        }

        private void txb_Enter(object sender, EventArgs e)
        {
            largo = 0;

            tmrSubrayado.Start();
        }
        private void txb_Leave(object sender, EventArgs e)
        {
            tmrSubrayado.Stop();

            InvalidateSubrayado();
        }

        void subrayar(TextBox ctb, PaintEventArgs e, decimal largo)
        {
            if (largo == 1)
            {
                Pen pen = new(enfasis, 5);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    ctb.Location.X,
                    ctb.Location.Y + ctb.Height + 5,
                    (int)(ctb.Location.X + ctb.Width * largo),
                    ctb.Location.Y + ctb.Height + 5
                );
            }
            else
            {
                Pen pen = new(contraste, 5);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    (int)(ctbNombre.Location.X + ctbNombre.Width * largo),
                    ctb.Location.Y + ctb.Height + 5,
                    ctb.Location.X + ctb.Width,
                    ctb.Location.Y + ctb.Height + 5
                );

                pen.Color = enfasis;

                e.Graphics.DrawLine
                (
                    pen,
                    ctb.Location.X,
                    ctb.Location.Y + ctb.Height + 5,
                    (int)(ctbNombre.Location.X + ctbNombre.Width * largo),
                    ctb.Location.Y + ctb.Height + 5
                );
            }
        }
        void subrayar(TextBox ctb, PaintEventArgs e)
        {
            Pen pen = new(contraste, 5);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine
            (
                pen,
                ctb.Location.X,
                ctb.Location.Y + ctb.Height + 5,
                ctb.Location.X + ctb.Width,
                ctb.Location.Y + ctb.Height + 5
            );
        }

        private void tmrSubrayado_Tick(object sender, EventArgs e)
        {
            if (largo < (decimal)0.995)
            {
                largo += decimal.Round((1 - largo) / 3, 4);

                InvalidateSubrayado();
            }
            else
            {
                largo = 1;

                InvalidateSubrayado();

                tmrSubrayado.Stop();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ctbNombre.Enabled = false;
            ctbContra.Enabled = false;
            ctbCContra.Enabled = false;



            bgwCheck.RunWorkerAsync();
            
            //Para dividir una string y recuperar una linea.
            //var coso = datos.Split("\n").ToList();
            //MessageBox.Show(coso[1]);

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



            InvalidateSubrayado();
        }

        void InvalidateSubrayado()
        {
            Rectangle rect = new(ctbNombre.Location.X - 5, ctbNombre.Location.Y, ctbNombre.Location.X + ctbNombre.Width + 5, ctbCContra.Location.Y + ctbCContra.Height);
            this.Invalidate(rect);
        }

        private void btnContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (ctbContra.UseSystemPasswordChar)
            {
                Pen pen = new(contraste, 3);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnContra.Height - 5, btnContra.Width - 5, 5);
            }
        }

        private void btnCContra_Click(object sender, EventArgs e)
        {
            ctbCContra.UseSystemPasswordChar = !ctbCContra.UseSystemPasswordChar;
            btnCContra.Refresh();
        }

        private void btnCContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (ctbCContra.UseSystemPasswordChar)
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

                InvalidateSubrayado();
            }
            else if (ctbContra.Location.Y <= ctbCContra.Location.Y)
            {
                int cambio = (ctbCContra.Location.Y - ctbContra.Location.Y) / 4 + 1;

                ctbNombre.Location = new Point(ctbNombre.Location.X, ctbNombre.Location.Y + cambio);
                ctbContra.Location = new Point(ctbContra.Location.X, ctbContra.Location.Y + cambio);
                btnContra.Location = new Point(btnContra.Location.X, btnContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);



                InvalidateSubrayado();
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

                InvalidateSubrayado();
            }
            else if (ctbCContra.Location.X >= ctbContra.Location.X)
            {
                int cambio = (ctbContra.Location.X - ctbCContra.Location.X) / 2 - 1;

                ctbCContra.Location = new Point(ctbCContra.Location.X + cambio, ctbCContra.Location.Y);
                btnCContra.Location = new Point(btnCContra.Location.X + cambio, btnCContra.Location.Y);

                cambio = (xPlus - pbPlusUser.Location.X) / 2 - 1;

                pbPlusUser.Location = new Point(pbPlusUser.Location.X + cambio, pbPlusUser.Location.Y);

                InvalidateSubrayado();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}