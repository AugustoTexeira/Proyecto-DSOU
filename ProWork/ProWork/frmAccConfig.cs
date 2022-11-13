
namespace ProWork
{
    public partial class frmAccConfig : Form
    {
        public frmAccConfig()
        {
            InitializeComponent();
        }
        public frmAccConfig(string user)
        {
            InitializeComponent();
            this.Text = "⚙️ Configuración: " + user;
            utbNombre.PlaceholderText = user;
            utbContra.PlaceholderText = "Vacío: Contraseña anterior";
            utbCContra.PlaceholderText = "Vacío: Contraseña anterior";
            BackColor = Estilo.fondo;
            lblCContra.ForeColor = Estilo.Contraste;
            lblContra.ForeColor = Estilo.Contraste;
            lblNombre.ForeColor = Estilo.Contraste;
            De_Configuración__Cristian_.ConfigContainer.ColorSwap += swapColor;
        }
        private void swapColor (object sender, EventArgs e)
        {
            BackColor = Estilo.fondo;
            lblCContra.ForeColor = Estilo.Contraste;
            lblContra.ForeColor = Estilo.Contraste;
            lblNombre.ForeColor = Estilo.Contraste;
            utbCContra.BackColor = Estilo.fondo;
            utbContra.BackColor = Estilo.fondo;
            utbNombre.BackColor = Estilo.fondo;
        }

        private async void cbtGuardar_Click(object sender, EventArgs e)
        {
            if (utbCContra.txbText == utbContra.txbText)
            {
                var con = await Program.openConnectionAsync();
                if (utbNombre.txbText != "" && utbContra.txbText != "")
                {
                    MySqlCommand cmd = new($"update usuario set nombre='{utbNombre.txbText}', password=sha2('{utbContra.txbText}', 224) where nombre='{utbNombre.PlaceholderText}' and not exists(select administrador from(select administrador, nombre from usuario)as t where nombre ='{utbNombre.txbText}');", con);
                    if(cmd.ExecuteNonQuery() == 1)
                    {
                        Program.user = utbNombre.txbText;
                        CambioExitoso.Invoke(utbNombre.txbText, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una cuenta con ese nombre.");
                    }
                }
                else
                {
                    if (utbNombre.txbText != "")
                    {
                        MySqlCommand cmd = new($"update usuario set nombre='{utbNombre.txbText}' where nombre='{utbNombre.PlaceholderText}' and not exists(select administrador from(select administrador, nombre from usuario)as t where nombre ='{utbNombre.PlaceholderText}');", con);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Program.user = utbNombre.txbText;
                            CambioExitoso.Invoke(utbNombre.txbText, e);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ya existe una cuenta con ese nombre.");
                        }
                    }
                    else
                    {
                        if (utbContra.txbText != "")
                        {
                            MySqlCommand cmd = new($"update usuario set password=sha2('{utbContra.txbText}', 224) where nombre='{utbNombre.PlaceholderText}';", con);
                            cmd.ExecuteNonQuery();

                            CambioExitoso.Invoke(null, e);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe completar algún campo para realizar cambios.");
                        }
                    }
                }
                Program.closeOpenConnection();
            }
            else
            {
                MessageBox.Show("Las constraseñas deben coincidir.");
            }
        }
        public event EventHandler CambioExitoso; //Si se cambia el nombre es el object, sino el object es null.

        private void frmAccConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) { Application.Exit(); }
            Dispose();
        }

        private void frmAccConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
