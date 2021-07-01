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
        private const int SaltSize = 16;

        // The size of the hash
        private const int HashSize = 20;

        // The num of iteration of Rfc2898DeriveBytes
        private const int Iterations = 5;

        public static string HashString(string password)
        {
            // Create the salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Create the password hash
            var pbkf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            var hash = pbkf2.GetBytes(HashSize);

            // Combine the salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert it to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            return base64Hash;
        }

        public static bool Verify(string password, string hashPassword)
        {
            // Convert the base64 to bytes
            var hashBytes = Convert.FromBase64String(hashPassword);

            // Get the salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Create the password hash with the salt
            var pbkf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkf2.GetBytes(HashSize);

            // Check every byte
            for(var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
