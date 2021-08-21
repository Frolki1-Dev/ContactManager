using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Views;

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

            if (Helper.FinishSetup())
            {
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new Welcome());
            }
        }
    }
}
