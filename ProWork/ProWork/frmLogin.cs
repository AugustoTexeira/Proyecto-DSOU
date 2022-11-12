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
            Program.tryToConnect();

            //UserCredential credencial;

            //using (var stream = new FileStream(@"C:\Users\Cristian\source\repos\Proyecto-DSOU\ProWork\ProWork\archivo1.json", FileMode.Open, FileAccess.Read))
            //{
            //    string creadPath = "token.json";

            //    credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(
            //        GoogleClientSecrets.Load(stream).Secrets,
            //        Program.Scope,
            //        "user",
            //        CancellationToken.None,
            //        new FileDataStore(creadPath, true)).Result;
            //}

            //var service = new DriveService(new BaseClientService.Initializer()
            //{
            //    HttpClientInitializer = credencial,
            //    ApplicationName = Program.ApplicationName
            //});

            //string pageToken = null;

            //FilesResource.ListRequest list = service.Files.List();
            //list.PageSize = 10;
            //list.PageToken = pageToken;
            //list.Fields = "nextPageToken, files(id), files(name)";

            //var request = list.Execute();

            //if (request.Files != null && request.Files.Count > 0)
            //{
            //    string a = "";
            //    foreach (var file in request.Files)
            //    {
            //        a += $"id: {file.Id} Name: {file.Name}\n";
            //    }

            //    MessageBox.Show(a);
            //}
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
                        MySqlCommand Registro = new($"insert into usuario(nombre, password, administrador) select * from (select '{ctbNombre.txbText}', SHA2('{ctbCContra.txbText}', 224), false) as t where not exists(select nombre from usuario where nombre='{ctbNombre.txbText}')", Program.connection);
                        if(Registro.ExecuteNonQuery() == 1)
                        {
                            Program.user = ctbNombre.txbText;
                            Program.userAdmin = false;
                            e.Result = true;
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
                    MySqlCommand vLogin = new($"select nombre, password, administrador from usuario where password=sha2('{ctbContra.txbText}', 224) and nombre='{ctbNombre.txbText}';", Program.connection);
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
                btnLogin.Texto = "Ingresar";
                btnSwap.Text = "¿No tienes una cuenta? Regístrate";
                ctbCContra.Visible = false;
                epbPlusUser.Visible = false;
                tmrIntoLogin.Stop();
            }
        }

        private void tmrIntoRegister_Tick(object sender, EventArgs e)
        {
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

        private void graficaContainer1_Click(object sender, EventArgs e)
        {

        }

        private void graficaContainer1_Load(object sender, EventArgs e)
        {

        }
    }
}