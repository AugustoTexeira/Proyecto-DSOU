using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ProWork
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprowork; Uid=root; Pwd=;");
        //Paleta de colores
        Color enfasis = Color.Blue;
        Color contraste = Color.White;
        Color fondoprincipal = Color.DarkBlue;
        /* 
         Nomenclatura:
            txb = TextBox
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

        //Procesos

        decimal largo = 1; //Porcentaje de progreso de énfasis. 1 = 100%
        public frmLogin()
        {
            InitializeComponent();
            yContra = txbContra.Location.Y;
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

            if (txbNombre.Focused)
            {
                subrayar(txbNombre, e, largo);
                subrayar(txbContra, e);
                subrayar(txbCContra, e);
            }
            else if (txbContra.Focused)
            {
                subrayar(txbNombre, e);
                subrayar(txbContra, e, largo);
                subrayar(txbCContra, e);
            }
            else if (txbCContra.Focused)
            {
                subrayar(txbNombre, e);
                subrayar(txbContra, e);
                subrayar(txbCContra, e, largo);
            }
            else if (txbCContra.Visible)
            {
                subrayar(txbNombre, e);
                subrayar(txbContra, e);
                subrayar(txbCContra, e);
            }
            else
            {
                subrayar(txbNombre, e);
                subrayar(txbContra, e);
            }
        }

        private void pbxOContra_Click(object sender, EventArgs e)
        {
            txbContra.UseSystemPasswordChar = !txbContra.UseSystemPasswordChar;
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

        void subrayar(TextBox txb, PaintEventArgs e, decimal largo)
        {
            if (largo == 1)
            {
                Pen pen = new(enfasis, 5);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine
                (
                    pen,
                    txb.Location.X,
                    txb.Location.Y + txb.Height + 5,
                    (int)(txb.Location.X + txb.Width * largo),
                    txb.Location.Y + txb.Height + 5
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
                    (int)(txbNombre.Location.X + txbNombre.Width * largo),
                    txb.Location.Y + txb.Height + 5,
                    txb.Location.X + txb.Width,
                    txb.Location.Y + txb.Height + 5
                );

                pen.Color = enfasis;

                e.Graphics.DrawLine
                (
                    pen,
                    txb.Location.X,
                    txb.Location.Y + txb.Height + 5,
                    (int)(txbNombre.Location.X + txbNombre.Width * largo),
                    txb.Location.Y + txb.Height + 5
                );
            }
        }
        void subrayar(TextBox txb, PaintEventArgs e)
        {
            Pen pen = new(contraste, 5);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine
            (
                pen,
                txb.Location.X,
                txb.Location.Y + txb.Height + 5,
                txb.Location.X + txb.Width,
                txb.Location.Y + txb.Height + 5
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
            txbNombre.Enabled = false;
            txbContra.Enabled = false;
            txbCContra.Enabled = false;



            bgwCheck.RunWorkerAsync();
            
            //Para dividir una string y recuperar una linea.
            //var coso = datos.Split("\n").ToList();
            //MessageBox.Show(coso[1]);

        }
        private void checkLogin(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (txbCContra.Visible) // Registro
            {
                if (txbCContra.Text == txbContra.Text && txbNombre.Text != "")
                {
                    try
                    {
                        MySqlCommand vRegistro = new("select nombre from usuario;", conexion);
                        MySqlDataReader reader = vRegistro.ExecuteReader();

                        bool v = true;

                        while (reader.Read())
                        {
                            if (txbNombre.Text == reader.GetString(0))
                            {
                                v = false;
                            }
                        }

                        if (v)
                        {
                            MySqlCommand iRegistro = new("insert into usuarios (nombre, contrasenia, administrador) " +
                                                        "values('" + txbNombre.Text + "','" + txbContra.Text + "' false);",
                                                        conexion
                                                        );
                            e.Result = new frmMain(txbNombre.Text, false);
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
                    MySqlCommand vLogin = new("select nombre, contrasenia, administrador from usuario;", conexion);
                    MySqlDataReader reader = vLogin.ExecuteReader();

                    bool v = false;
                    bool admin = false;

                    while (reader.Read())
                    {
                        if (txbNombre.Text == reader.GetString(0) && txbContra.Text == reader.GetString(1))
                        {
                            v = true;
                            admin = reader.GetBoolean(2);
                        }
                    }

                    if (v)
                    {
                        e.Result = new frmMain(txbNombre.Text, admin);
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
            if (txbCContra.Visible)
            {
                tmrIntoRegister.Stop();
                tmrIntoLogin.Start();
            }
            else
            {
                txbCContra.Visible = true;
                btnCContra.Visible = true;
                tmrIntoLogin.Stop();
                tmrIntoRegister.Start();
            }



            InvalidateSubrayado();
        }

        void InvalidateSubrayado()
        {
            Rectangle rect = new(txbNombre.Location.X - 5, txbNombre.Location.Y, txbNombre.Location.X + txbNombre.Width + 5, txbCContra.Location.Y + txbCContra.Height);
            this.Invalidate(rect);
        }

        private void btnContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (txbContra.UseSystemPasswordChar)
            {
                Pen pen = new(contraste, 3);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnContra.Height - 5, btnContra.Width - 5, 5);
            }
        }

        private void btnCContra_Click(object sender, EventArgs e)
        {
            txbCContra.UseSystemPasswordChar = !txbCContra.UseSystemPasswordChar;
            btnCContra.Refresh();
        }

        private void btnCContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (txbCContra.UseSystemPasswordChar)
            {
                Pen pen = new(contraste, 3);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnCContra.Height - 5, btnCContra.Width - 5, 5);
            }
        }

        private void tmrIntoLogin_Tick(object sender, EventArgs e)
        {
            if (txbCContra.Location.X < this.Width)
            {
                int cambio = (this.Width - txbCContra.Location.X) / 2 + 1;

                txbCContra.Location = new Point(txbCContra.Location.X + cambio, txbCContra.Location.Y);
                btnCContra.Location = new Point(btnCContra.Location.X + cambio, btnCContra.Location.Y);

                InvalidateSubrayado();
            }
            else if (txbContra.Location.Y <= txbCContra.Location.Y)
            {
                int cambio = (txbCContra.Location.Y - txbContra.Location.Y) / 4 + 1;

                txbNombre.Location = new Point(txbNombre.Location.X, txbNombre.Location.Y + cambio);
                txbContra.Location = new Point(txbContra.Location.X, txbContra.Location.Y + cambio);
                btnContra.Location = new Point(btnContra.Location.X, btnContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);


                InvalidateSubrayado();
            }
            else
            {
                btnLogin.Text = "Ingresar";
                btnSwap.Text = "¿No tienes una cuenta? Regístrate";
                txbCContra.Visible = false;
                btnCContra.Visible = false;
                tmrIntoLogin.Stop();
            }
        }

        private void tmrIntoRegister_Tick(object sender, EventArgs e)
        {
            if (txbContra.Location.Y >= yContra)
            {
                txbCContra.Visible = true;
                btnContra.Visible = true;

                int cambio = (294 - txbContra.Location.Y) / 4 - 1;

                txbNombre.Location = new Point(txbNombre.Location.X, txbNombre.Location.Y + cambio);
                txbContra.Location = new Point(txbContra.Location.X, txbContra.Location.Y + cambio);
                btnContra.Location = new Point(btnContra.Location.X, btnContra.Location.Y + cambio);
                pbxUser.Location = new Point(pbxUser.Location.X, pbxUser.Location.Y + cambio);

                InvalidateSubrayado();
            }
            else if (txbCContra.Location.X >= txbContra.Location.X)
            {
                int cambio = (txbContra.Location.X - txbCContra.Location.X) / 2 - 1;

                txbCContra.Location = new Point(txbCContra.Location.X + cambio, txbCContra.Location.Y);
                btnCContra.Location = new Point(btnCContra.Location.X + cambio, btnCContra.Location.Y);

                InvalidateSubrayado();
            }
            else
            {
                btnLogin.Text = "Crear";
                btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
                tmrIntoRegister.Stop();
            }
        }

        private void bgwCheck_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            txbNombre.Enabled = true;
            txbContra.Enabled = true;
            txbCContra.Enabled = true;

            if(e.Result != null)
            {
                frmMain main = (frmMain)e.Result;
                main.Show();
                this.Hide();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}