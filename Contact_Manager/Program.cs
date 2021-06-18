using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Let's check some common places
            // TODO: Define common places, where the database could be stored
            // Or should we create a small file in the %appdata% dir to see which databases the client opened?
            // Now should the force be with us that we can do the stuffs.
            // Check temp directory
            string databaseFile = Path.GetTempPath() + "dev_db.sqlite";

            try
            {
                DatabaseConnection.buildDatabaseConnection(databaseFile);
                Application.Run(new Form1());
            } catch(FileNotFoundException)
            {
                // Display the database selection or setup
                Application.Run(new Welcome());
            }


            // TODO: Add here the check if I find the database or not.
            /*if(!DatabaseConnection.hasActiveConnection())
            {
                // Display the database selection or setup
                Application.Run(new Welcome());
            } else
            {
                Application.Run(new Form1());
            }*/
        }
    }
}
