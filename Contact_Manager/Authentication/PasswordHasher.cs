using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Authentication
{
    class PasswordHasher
    {
        // The size of the salt
        private const int saltSize = 16;

        // The size of the hash
        private const int hashSize = 20;

        // The num of iteration of Rfc2898DeriveBytes
        private const int iterations = 5;

        public static string hashString(string password)
        {
            // Create the salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[saltSize]);

            // Create the password hash
            var pbkf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkf2.GetBytes(hashSize);

            // Combine the salt and hash
            var hashBytes = new byte[saltSize + hashSize];
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hash, 0, hashBytes, saltSize, hashSize);

            // Convert it to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            return base64Hash;
        }

        public static bool verify(string password, string hashPassword)
        {
            // Convert the base64 to bytes
            var hashBytes = Convert.FromBase64String(hashPassword);

            // Get the salt
            var salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            // Create the password hash with the salt
            var pbkf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkf2.GetBytes(hashSize);

            // Check every byte
            for(var i = 0; i < hashSize; i++)
            {
                if (hashBytes[i + saltSize] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
