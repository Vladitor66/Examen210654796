namespace sistemasventas.VISTA
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Examen2.Consulta1());
            Application.Run(new Examen2.Consulta2());
            Application.Run(new Examen2.Consulta3());
            Application.Run(new Examen2.Consulta4());
            Application.Run(new Examen2.Consulta5());
        }
    }
}