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

        decimal largo = 1; //Porcentaje de progreso de énfasis. 1 = 100%
        public frmLogin()
        {
            InitializeComponent();
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
            //Rectangle rect = new(pbxOCContra.Location, pbxOCContra.Size);

            this.Invalidate();
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
                    (int)(txbNombre.Location.X + txbNombre.Width * largo),
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
                    txbNombre.Location.X + txbNombre.Width,
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
                btnCContra.Location.X + btnCContra.Width,
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
            string datos = "";
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=baseagencia; Uid=root; Pwd=;");

                conexion.Open();

                MySqlCommand cmd = new("show databases", conexion);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\nIngrese algo correcto");
            }
            MessageBox.Show(datos);

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (txbCContra.Visible)
            {
                txbCContra.Visible = false;
                btnCContra.Visible = false;
                btnLogin.Text = "Ingresar";
                btnSwap.Text = "¿No tienes una cuenta? Regístrate";
            }
            else
            {
                txbCContra.Visible = true;
                btnCContra.Visible = true;
                btnLogin.Text = "Crear";
                btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
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

        private void pbxOContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (!txbContra.UseSystemPasswordChar)
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
            this.Refresh();
        }

        private void btnCContra_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (!txbCContra.UseSystemPasswordChar)
            {
                Pen pen = new(contraste, 3);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                e.Graphics.DrawLine(pen, 5, btnCContra.Height - 5, btnCContra.Width - 5, 5);
            }
        }
    }
}