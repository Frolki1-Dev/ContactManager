using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// TODO: Connect with the Employee model
namespace Contact_Manager.Authentication
{
    class Authentication
    {
        private static bool authenticated = false;
        private static int user_id;
        private static string name;

        /**
         * Try to authenticate the user
         */
        public static bool authenticate(string id, string password)
        {
            return false;
        }

        /**
         * Checks if the user is authenticated
         */
        public static bool isAuthenticated()
        {
            return authenticated;
        }

        /**
         * Return the name of the user
         */
        public static string getName()
        {
            return name;
        }

        /**
         * Get the user id from the user
         */
        public static int getUserId()
        {
            return user_id;
        }
    }
}
