global using MySqlConnector;
namespace ProWork
{
    using Google.Apis.Drive.v3;
    using System.Data;
    internal static class Program
    {
        public static bool userAdmin = false;
        public static string user = "";
        public static long userId = 0;
        private static MySqlConnection sql = new("Server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com; Database=ac2ds4m3udhpr2r9; Uid=m615ts369w6vo3nu; Pwd=xh288kbnw4ixluu4");
        private static bool executingsql = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            MessageBox.Show(Properties.Setttings.Default.Theme.ToString());
            if (Properties.Setttings.Default.Theme)
            {
                Estilo.enfasis = Color.FromArgb(5, 49, 247);
                Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
                Estilo.fondo = Color.White;
                Estilo.Contraste = Color.FromArgb(15, 12, 15);
                Estilo.contrasteLigero = Color.LightGray;
                Estilo.degrContraste = Color.Gray;
            }
            else
            {
                Estilo.enfasis = Color.FromArgb(5, 49, 247);
                Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
                Estilo.fondo = Color.FromArgb(15, 12, 15);
                Estilo.Contraste = Color.White;
                Estilo.contrasteLigero = Color.Gray;
                Estilo.degrContraste = Color.LightGray;
            }

            GoogleInfo.CrearToken();
            tryToConnectEnvironment();
            if(Properties.Setttings.Default.User == "")
            {
                frmLogin frm = new();
                frm.CreateControl();
                frm.Show();
            }
            else
            {
                MySqlConnection con = openConnection();
                MySqlCommand vLogin = new($"select administrador, idusuario from usuario where binary password=sha2('{Properties.Setttings.Default.UserPassword}', 224) and nombre='{Properties.Setttings.Default.User}';", con);
                MySqlDataReader reader = vLogin.ExecuteReader();
                bool v = false;

                while (reader.Read())
                {
                    v = true;
                    userAdmin = reader.GetBoolean(0);
                    userId = reader.GetInt64(1);
                    user = Properties.Setttings.Default.User;
                }
                reader.Close();
                if (v)
                {
                    frmMain main = new();
                    main.Show();
                }
                else
                {
                    frmLogin frm = new();
                    frm.CreateControl();
                    frm.Show();
                }
            }
            closeOpenConnection();
            Application.Run();
        }
        private static async Task tryToConnectAsync()
        {
            try
            {
                await sql.OpenAsync();
            }
            catch
            {
                if(MessageBox.Show("Se ha perdido la conexión con el servidor. ¿Desea Reconectar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    await tryToConnectAsync();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private static void tryToConnect()
        {
            try
            {
                sql.OpenAsync();
            }
            catch
            {
                if (MessageBox.Show("Se ha perdido la conexión con el servidor. ¿Desea Reconectar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    tryToConnect();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private static void tryToConnectEnvironment()
        {
            try
            {
                sql.Open();
            }
            catch
            {
                if (MessageBox.Show("Se ha perdido la conexión con el servidor. ¿Desea Reconectar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    tryToConnectEnvironment();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
        public static void closeOpenConnection ()
        {
            executingsql = false;
        }
        public async static Task<MySqlConnection> openConnectionAsync ()
        {
            if (!executingsql)
            {
                executingsql = true;
                return sql;
            }
            else
            {
                await Task.Delay(5);
                return await openConnectionAsync();
            }
        }
        public static MySqlConnection openConnection()
        {
            if (!executingsql)
            {
                executingsql = true;
                return sql;
            }
            else
            {
                Task.Delay(5);
                return openConnection();
            }
        }
    }
}