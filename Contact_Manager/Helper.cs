using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    public static class Helper
    {
        /**
         * Get the user profile path from the user.
         * If you want you can also append path to the user profile path.
         */
        public static string GetUserProfilePath(string append = "")
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + append.Trim('\\');
        }

        /**
         * Get the application data path
         */
        public static string GetApplicationDataPath(string append = "")
        {
            return GetUserProfilePath("_crm") + "\\" + append.Trim('\\');
        }

        /**
         * Get the %appdata% path.
         * If you want you can also append path to the %appdata% path.
         */
        public static string GetAppDataPath(string append = "")
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + append.Trim('\\');
        }

        /**
         * Checks if the application setup is done
         */
        public static bool FinishSetup()
        {
            // Check if application data folder exists
            if (!Directory.Exists(GetApplicationDataPath()))
            {
                return false;
            }

            // Check if the binary data files exists
            if (!File.Exists(GetApplicationDataPath("users.dat")) || 
                !File.Exists(GetApplicationDataPath("employees.dat")) || 
                !File.Exists(GetApplicationDataPath("trainees.dat")) || 
                !File.Exists(GetApplicationDataPath("customers.dat")))
            {
                return false;
            }

            return true;
        }

        /**
         * Helps to close the old form and open the new in the correct position
         */
        public static void OpenNewFormAndCloseOld(Form newForm, Form oldForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;
            oldForm.Hide();
            newForm.ShowDialog();
            oldForm.Close();
        }
    }
}
