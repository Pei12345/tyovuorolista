using System;
using System.IO;
using System.Windows.Forms;
using TyovuoroLista.View;

namespace TyovuoroLista
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Directory.CreateDirectory(".\\Periodit");
            Directory.CreateDirectory(".\\Kommentit");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PeriodiView());
        }
    }
}
