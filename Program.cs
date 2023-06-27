using Google.Cloud.Firestore;
using IronSoftware;

namespace PrimerParcialLabo_Intento2
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
            Logger.LoggingMode = (Logger.LoggingModes)8;
            Logger.LogFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//logCrash.txt";
            Application.Run(new frmLogIn());
        }
    }
}