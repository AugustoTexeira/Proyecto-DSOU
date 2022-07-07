using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ProWork
{
    public partial class frmLogin : Form
    {
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
            - Los ojitos no siempre se tachan en las situaciones correctas.
            - Hay sobrelapado en las animaciones de IntoLogin/Register.
        */
        //Felxibilidad
        private int yContra;

        decimal largo = 1; //Porcentaje de progreso de �nfasis. 1 = 100%
        public frmLogin()
        {
            InitializeComponent();
            yContra = txbContra.Location.Y;
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

            Rectangle rect = new(btnContra.Location, btnContra.Size);
            this.Invalidate(rect);
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

        void subrayar (TextBox txb, PaintEventArgs e, decimal largo)
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
        void subrayar (TextBox txb, PaintEventArgs e)
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
            if (txbCContra.Visible) // Registro
            {
                if (txbCContra.Text == txbContra.Text)
                {
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dbprowork; Uid=root; Pwd=;");
                        conexion.Open();
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

                            frmMain main = new(txbNombre.Text, false);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("La cuenta ya existe.");
                        }
                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + "\n Ingrese algo correcto.");
                    }
                }
                else
                {
                    MessageBox.Show("Las contrase�as no coinciden.");
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
                        frmMain main = new(txbNombre.Text, admin);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No existe cuenta con tal nombre y contrase�a.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\n Ingrese algo correcto.");
                }
            }

            //Para dividir una string y recuperar una linea.
            //var coso = datos.Split("\n").ToList();
            //MessageBox.Show(coso[1]);

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
                tmrIntoLogin.Stop();
                tmrIntoRegister.Start();
            }

            

            InvalidateSubrayado();
        }

        private void pnlForeground_Paint(object sender, PaintEventArgs e)
        {
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

            Rectangle rect = new(btnCContra.Location, btnCContra.Size);
            this.Invalidate(rect);
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
                btnSwap.Text = "�No tienes una cuenta? Reg�strate";
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
                btnSwap.Text = "�Tienes una cuenta? Inicia sesi�n";
                txbCContra.Visible = true;
                btnCContra.Visible = true;
                tmrIntoRegister.Stop();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}