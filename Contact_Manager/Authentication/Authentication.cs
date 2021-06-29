using Contact_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contact_Manager.Authentication
{
    class Authentication
    {
        private static bool _authenticated = false;
        private static User _user;

        /**
         * Try to authenticate the user
         */
        public static bool Authenticate(string username, string password)
        {
            return false;
        }

        /**
         * Checks if the user is authenticated
         */
        public static bool IsAuthenticated()
        {
            return _authenticated;
        }

        /**
         * Get the authenticated user
         */
        public static User GetUser()
        {
            return _user;
        }
    }
}
