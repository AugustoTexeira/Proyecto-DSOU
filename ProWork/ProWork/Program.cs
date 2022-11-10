namespace ProWork
{
    using MySql.Data.MySqlClient;
    using Google.Apis.Drive.v3;
    using System.Data;
    internal static class Program
    {
        public static string[] Scope = { DriveService.Scope.Drive };
        public static string ApplicationName = "Patata";
        public static MySqlConnection connection = new("Server=localhost; Database=prowork; Uid=root; Pwd=;");
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

        private static void DisplaySchemaTableInfo(DataTableReader reader, int ordinal)
        {
            // Given a DataTableReader, display schema
            // information about a particular column.
            try
            {
                DataTable schemaTable = reader.GetSchemaTable();
                DataRow row = schemaTable.Rows[ordinal];
                foreach (DataColumn col in schemaTable.Columns)
                {
                    MessageBox.Show("{0}: {1}",
                        col.ColumnName);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("{0} is an invalid column number.",
                    ordinal);
            }
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
                if (MessageBox.Show("Se ha perdido la conexión con la base de datos.\n¿Desea intentar reconectar?", "Error de conexión", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    environmentalTryToConnect();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        public static void tryToConnect()
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
                if (MessageBox.Show("Se ha perdido la conexión con la base de datos.\n¿Desea intentar reconectar?", "Error de conexión", MessageBoxButtons.YesNo) == DialogResult.Yes) 
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