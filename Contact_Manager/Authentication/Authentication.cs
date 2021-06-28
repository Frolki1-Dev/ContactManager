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
        private static bool authenticated = false;
        private static User user;

        /**
         * Try to authenticate the user
         */
        public static bool authenticate(string username, string password)
        {
            User u = new User();

            // Find the user
            u.getByUsername(username);

            // Exists?
            if(u.id == 0)
            {
                return false;
            }

            // Check the password
            if(!PasswordHasher.verify(password, u.password)) {
                return false;
            }

            // Okay everything is okay
            user = u;
            authenticated = true;

            return true;
        }

        /**
         * Checks if the user is authenticated
         */
        public static bool isAuthenticated()
        {
            return authenticated;
        }

        /**
         * Get the authenticated user
         */
        public static User getUser()
        {
            return user;
        }

        /**
         * Get the user id from the user
         */
        public static int getUserId()
        {
            return user.id;
        }
    }
}
