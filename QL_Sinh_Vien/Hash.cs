using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien
{
    internal static class Hash
    {
        private static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

        internal static string HashPassword(string password)
        {
            password = ComputeHash(password, new MD5CryptoServiceProvider());
            password = ComputeHash(password, new SHA256CryptoServiceProvider());
            return password;
        }

        internal static bool checkPass(string password, string PassDB)
        {
            password = ComputeHash(password, new MD5CryptoServiceProvider());
            password = ComputeHash(password, new SHA256CryptoServiceProvider());
            if (PassDB.CompareTo(password) == 0)
                return true;
            return false;
        }
    }
}
