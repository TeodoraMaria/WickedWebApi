using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL
{
    public class PasswordHashing
    {
        private static readonly byte[] _saltBytes = new byte[] {0, 1, 1, 0, 0, 1,0,0,1};

        public static string Hash(string value)
        {
            return Encoding.UTF7.GetString(Hash(Encoding.UTF8.GetBytes(value), _saltBytes));
        }

        private static byte[] Hash(byte[] value, byte[] salt)
        {
            byte[] saltedValue = value.Concat(salt).ToArray();
            // Alternatively use CopyTo.
            //var saltedValue = new byte[value.Length + salt.Length];
            //value.CopyTo(saltedValue, 0);
            //salt.CopyTo(saltedValue, value.Length);

            return new SHA256Managed().ComputeHash(saltedValue);
        }
        public static bool ConfirmPassword(string reactPassword,string bdPass)
        {
            byte[] passwordHash = Encoding.UTF8.GetBytes(Hash(reactPassword));

            return Encoding.UTF8.GetBytes(bdPass).SequenceEqual(passwordHash);
        }
    }
}
