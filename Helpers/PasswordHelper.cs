using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Helpers
{
    public static class PasswordHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));


                if (storedHash.Length != computedHash.Length)
                    return false;

                return computedHash.SequenceEqual(storedHash);
            }
        }

        public static (byte[] hash, byte[] salt) GeneratePasswordHashAndSalt(string password)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                var salt = hmac.Key;
                var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // Hash password
                return (hash, salt);
            }
        }

    }
}
