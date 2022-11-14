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
        private static MySqlConnection sql = new("Server=localhost; Database=prowork; Uid=root; Pwd=");
        private static bool executingsql = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            sql.Open();

            ApplicationConfiguration.Initialize();

            Estilo.enfasis = Color.FromArgb(5, 49, 247);
            Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
            Estilo.fondo = Color.FromArgb(15, 12, 15);
            Estilo.Contraste = Color.White;
            Estilo.contrasteLigero = Color.Gray;
            Estilo.degrContraste = Color.LightGray;

            GoogleInfo.CrearToken();

            frmLogin frm = new();
            frm.CreateControl();
            frm.Show();

            Application.Run();
        }
        private static void tryToConnect()
        {

        }
        public static void closeOpenConnection ()
        {
            executingsql = false;
        }
        public async static Task<MySqlConnection> openConnectionAsync ()
        {
            await Task.Delay(5);
            if (!executingsql)
            {
                executingsql = true;
                return sql;
            }
            else
            {
                var con = await openConnectionAsync();
                return con;
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
                MySqlConnection con = new("Server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com; Database=ac2ds4m3udhpr2r9; Uid=m615ts369w6vo3nu; Pwd=xh288kbnw4ixluu4;");
                try
                {
                    con.Open();
                }
                catch
                {
                    if (MessageBox.Show("Se ha perdido la conexi�n con la base de datos.\n�Desea intentar reconectar?", "Error de conexi�n", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        return openConnection();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                return con;
            }
        }
    }
}