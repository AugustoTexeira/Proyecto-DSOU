namespace ProWork
{
    using MySql.Data.MySqlClient;
    internal static class Program
    {
        public static MySqlConnection connection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            
            connection = new("Server=localhost; Database=prowork; Uid=root; Pwd=;");
            try
            {
                ApplicationConfiguration.Initialize();
                connection.Open();

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
            catch (Exception ex)
            {
                if (ex != null) 
                { 
                    MessageBox.Show("No se pudo establecer conexión.");
                    Application.Exit();
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
            catch (Exception ex)
            {
                if (ex != null) { MessageBox.Show("No se pudo establecer conexión."); }
            }
        }
    }
}