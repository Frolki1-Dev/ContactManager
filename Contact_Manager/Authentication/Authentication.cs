using Contact_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Collections;


namespace Contact_Manager.Authentication
{
    /**
     * Handles the authentication of the user
     */
    class Authentication
    {
        private static bool _authenticated = false;
        private static User _user;

        /**
         * Try to authenticate the user
         */
        public static bool Authenticate(string username, string password)
        {
            Users collection = DataContainer.GetUserCollection();

            // Make LINQ check
            IEnumerable<User> user = from User usr in collection
                where usr.Username == username
                select usr;

            // Count the result
            if (user.Count() != 1)
            {
                return false;
            }

            // Checks if the password is correct
            if (!PasswordHasher.Verify(password, user.First().Password))
            {
                return false;
            }

            // Check if the user is active
            if (!user.First().Active)
            {
                return false;
            }

            _user = user.First();
            _authenticated = true;

            return true;
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

        /**
         * Logout
         */
        public static void Logout()
        {
            _authenticated = false;
            _user = null;
        }
    }
}
