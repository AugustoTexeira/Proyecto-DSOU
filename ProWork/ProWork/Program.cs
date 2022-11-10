namespace ProWork
{
    using MySql.Data.MySqlClient;
    using Google.Apis.Drive.v3;
    using System.Data;
    internal static class Program
    {
        public static string[] Scope = { DriveService.Scope.Drive };
        public static string ApplicationName = "Patata";
        public static MySqlConnection connection = new("Server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com; Database=ac2ds4m3udhpr2r9; Uid=m615ts369w6vo3nu; Pwd=xh288kbnw4ixluu4;");
        public static bool userAdmin = false;
        public static string user = "";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            environmentalTryToConnect();

            Estilo.enfasis = Color.FromArgb(5, 49, 247);
            Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
            Estilo.fondo = Color.FromArgb(15, 12, 15);
            Estilo.Contraste = Color.White;
            Estilo.contrasteLigero = Color.Gray;
            Estilo.degrContraste = Color.LightGray;

            frmLogin frm = new();
            frm.CreateControl();
            frm.Show();

            Application.Run();
        }

        private static void environmentalTryToConnect()
        {
            try
            {
                if (!connection.Ping())
                {
                    connection.Open();
                }
            }
            catch
            {
                if (MessageBox.Show("Se ha perdido la conexi�n con la base de datos.\n�Desea intentar reconectar?", "Error de conexi�n", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    environmentalTryToConnect();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        public static async void tryToConnect()
        {
            try
            {
                if (!connection.Ping())
                {
                    await connection.OpenAsync();
                }
            }
            catch
            {
                if (MessageBox.Show("Se ha perdido la conexi�n con la base de datos.\n�Desea intentar reconectar?", "Error de conexi�n", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                { 
                    tryToConnect(); 
                } 
                else 
                {
                    Application.Exit(); 
                }
            }
        }
    }
}