using System;
using System.Windows.Forms;

namespace PSList
{
    static class Program
        {
        private static FormMain mainWindow;
        public static FormMain MainWindow
            {
            get { return mainWindow; }
            set { mainWindow = value; }
            }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
     
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            mainWindow = new FormMain();
            Application.Run(mainWindow);
            }
        }
    }
