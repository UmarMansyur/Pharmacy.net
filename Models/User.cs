using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace WindowsFormsApplication7.Models
{
    class User
    {
        public string Id { get; set; }
        public string Username{ get; set; }
        public string Password{ get; set; }
        public string Role{ get; set; }
        public string Hash{ get; set; }
        public string Salt{ get; set; }

        public static User GenerateSaltedHash(int size, string password)
        {
            try
            {
                var saltBytes = new byte[size];
                var provider = new RNGCryptoServiceProvider();
                provider.GetNonZeroBytes(saltBytes);
                var salt = Convert.ToBase64String(saltBytes);

                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
                var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

                User hashSalt = new User { Hash = hashPassword, Salt = salt };
                return hashSalt;
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);

                throw;
            }
            
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            try
            {
                var saltBytes = Convert.FromBase64String(storedSalt);
                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == storedHash;
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
            
        }
         

    }
}
