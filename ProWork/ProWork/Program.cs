namespace ProWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Estilo.enfasis = Color.FromArgb(5, 49, 247);
            Estilo.degrEnfasis = Color.FromArgb(5, 233, 237);
            Estilo.fondo = Color.FromArgb(15, 12, 15);
            Estilo.Contraste = Color.White;
            Estilo.contrasteLigero = Color.Gray;
            Estilo.degrContraste = Color.LightGray;

            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrueba());
        }
    }
}