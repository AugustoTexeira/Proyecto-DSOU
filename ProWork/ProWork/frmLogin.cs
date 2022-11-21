using System.Threading.Tasks;
using System.Threading;
using System.IO;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Json;
using Google.Apis.Services;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProWork
{
    public partial class frmLogin : Form
    {
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
            xPlus = epbPlusUser.Location.X;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ctbNombre.Enabled = false;
            ctbContra.Enabled = false;
            ctbCContra.Enabled = false;
            if(!bgwCheck.IsBusy)
            {
                bgwCheck.RunWorkerAsync();
            }
        }
        private void checkLogin(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (ctbCContra.Visible) // Registro
            {
                if (ctbCContra.txbText == ctbContra.txbText && ctbNombre.txbText != "")
                {
                    try
                    {
                        MySqlConnection con = Program.openConnection();
                        MySqlCommand Registro = new($"insert into usuario(nombre, password, administrador) select * from (select '{ctbNombre.txbText}', SHA2('{ctbCContra.txbText}', 224), false) as t where not exists(select nombre from usuario where nombre= binary '{ctbNombre.txbText}')", con);
                        if(Registro.ExecuteNonQuery() == 1)
                        {
                            Program.user = ctbNombre.txbText;
                            Program.userAdmin = false;
                            Program.userId = Registro.LastInsertedId;
                            e.Result = true;
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
                    MySqlConnection con = Program.openConnection();
                    MySqlCommand vLogin = new($"select nombre, password, administrador, idusuario from usuario where password= binary sha2('{ctbContra.txbText}', 224) and nombre= binary '{ctbNombre.txbText}';", con);
                    MySqlDataReader reader = vLogin.ExecuteReader();
                    bool v = false;
                    bool admin = false;

                    while (reader.Read())
                    {
                        if (ctbNombre.txbText == reader.GetString(0))
                        {
                            v = true;
                            admin = reader.GetBoolean(2);
                            Program.userId = reader.GetInt64(3);
                        }
                    }

                    reader.Close();
                    Program.closeOpenConnection();
                    if (v)
                    {
                        Program.user = ctbNombre.txbText;
                        Program.userAdmin = admin;
                        e.Result = true;
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
                epbPlusUser.Visible = true;
                ctbCContra.Visible = true;
                tmrIntoLogin.Stop();
                tmrIntoRegister.Start();
            }
        }

        private void tmrIntoLogin_Tick(object sender, EventArgs e)
        {
            ctbCContra.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ctbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ctbContra.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            epbUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            epbPlusUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            if (ctbCContra.Location.X < this.Width)
            {
                int cambio = (this.Width - ctbCContra.Location.X) / 2 + 1;

                ctbCContra.Location = new Point(ctbCContra.Location.X + cambio, ctbCContra.Location.Y);

                cambio = (this.Width - epbPlusUser.Location.X) / 2 + 1;

                epbPlusUser.Location = new Point(epbPlusUser.Location.X + cambio / 2, epbPlusUser.Location.Y);
            }
            else if (ctbContra.Location.Y <= ctbCContra.Location.Y)
            {
                int cambio = (ctbCContra.Location.Y - ctbContra.Location.Y) / 4 + 1;

                ctbNombre.Location = new Point(ctbNombre.Location.X, ctbNombre.Location.Y + cambio);
                ctbContra.Location = new Point(ctbContra.Location.X, ctbContra.Location.Y + cambio);
                epbUser.Location = new Point(epbUser.Location.X, epbUser.Location.Y + cambio);
            }
            else
            {

                ctbCContra.Anchor = AnchorStyles.Right;
                ctbNombre.Anchor = AnchorStyles.Right;
                ctbContra.Anchor = AnchorStyles.Right;
                epbUser.Anchor = AnchorStyles.Right;
                epbPlusUser.Anchor = AnchorStyles.Right;
                btnLogin.Texto = "Ingresar";
                btnSwap.Text = "¿No tienes una cuenta? Regístrate";
                ctbCContra.Visible = false;
                epbPlusUser.Visible = false;
                tmrIntoLogin.Stop();
            }
            ctbCContra.Anchor = AnchorStyles.Right;
            ctbNombre.Anchor = AnchorStyles.Right;
            ctbContra.Anchor = AnchorStyles.Right;
            epbUser.Anchor = AnchorStyles.Right;
            epbPlusUser.Anchor = AnchorStyles.Right;
        }

        private void tmrIntoRegister_Tick(object sender, EventArgs e)
        {
            ctbCContra.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ctbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ctbContra.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            epbUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            epbPlusUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            if (ctbContra.Location.Y >= yContra)
            {
                ctbCContra.Visible = true;

                int cambio = (yContra - ctbContra.Location.Y) / 4 - 1;
                ctbNombre.Location = new Point(ctbNombre.Location.X, ctbNombre.Location.Y + cambio);
                ctbContra.Location = new Point(ctbContra.Location.X, ctbContra.Location.Y + cambio);
                epbUser.Location = new Point(epbUser.Location.X, epbUser.Location.Y + cambio);
            }
            else if (ctbCContra.Location.X >= ctbContra.Location.X)
            {
                int cambio = (ctbContra.Location.X - ctbCContra.Location.X) / 2 - 1;

                ctbCContra.Location = new Point(ctbCContra.Location.X + cambio, ctbCContra.Location.Y);

                cambio = (xPlus - epbPlusUser.Location.X) / 2 - 1;

                epbPlusUser.Location = new Point(epbPlusUser.Location.X + cambio, epbPlusUser.Location.Y);
            }
            else
            {
                yContra = ctbContra.Location.Y;
                ctbCContra.Anchor = AnchorStyles.Right;
                ctbNombre.Anchor = AnchorStyles.Right;
                ctbContra.Anchor = AnchorStyles.Right;
                epbUser.Anchor = AnchorStyles.Right;
                epbPlusUser.Anchor = AnchorStyles.Right;
                btnLogin.Texto = "Crear";
                btnSwap.Text = "¿Tienes una cuenta? Inicia sesión";
                tmrIntoRegister.Stop();
            }
            ctbCContra.Anchor = AnchorStyles.Right;
            ctbNombre.Anchor = AnchorStyles.Right;
            ctbContra.Anchor = AnchorStyles.Right;
            epbUser.Anchor = AnchorStyles.Right;
            epbPlusUser.Anchor = AnchorStyles.Right;
        }

        private void bgwCheck_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ctbNombre.Enabled = true;
            ctbContra.Enabled = true;
            ctbCContra.Enabled = true;

            if(e.Result != null)
            {
                if (chb.Checked)
                {
                    Properties.Setttings.Default.User = ctbNombre.txbText;
                    Properties.Setttings.Default.UserPassword = ctbContra.txbText;
                    Properties.Setttings.Default.Save();
                }
                frmMain main = new();
                main.Show();
                this.Close();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            this.Dispose();
        }

        private void btnSwap_MouseEnter(object sender, EventArgs e)
        {
            btnSwap.Font = new(btnSwap.Font, FontStyle.Underline);
        }

        private void btnSwap_MouseLeave(object sender, EventArgs e)
        {
            btnSwap.Font = new(btnSwap.Font, FontStyle.Regular);
        }

        private void pnlForeground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            if (ctbCContra.Visible)
            {
                yContra = ctbContra.Location.Y;
                xPlus = epbPlusUser.Location.X;
            }
            else
            {
                xPlus = epbUser.Location.X + 97;
            }
        }
    }
}