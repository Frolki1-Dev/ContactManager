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

            string databaseFile = Helper.getUserProfilePath("crm.db");

            try
            {
                DatabaseConnection.buildDatabaseConnection(databaseFile);
                Application.Run(new Login());
            } catch(FileNotFoundException)
            {
                // Display the database selection or setup
                Application.Run(new Welcome());
            }
        }
    }
}
