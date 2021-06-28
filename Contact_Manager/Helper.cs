using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    public static class Helper
    {
        /**
         * Get the user profile path from the user.
         * If you want you can also append path to the user profile path.
         */
        public static string getUserProfilePath(string append = "")
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + append.Trim('\\');
        }

        /**
         * Get the %appdata% path.
         * If you want you can also append path to the %appdata% path.
         */
        public static string getAppDataPath(string append = "")
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + append.Trim('\\');
        }
    }
}
