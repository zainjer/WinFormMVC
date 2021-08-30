using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vplquiz.Resources
{
    public class Utils
    {
        public static string GetHash(string text)
        {
            using (SHA256 encrypt = SHA256.Create())
            {

                var encoding = new UnicodeEncoding();
                byte[] hashValue = encrypt.ComputeHash((encoding.GetBytes(text)));

                var hash = Convert.ToBase64String(hashValue);
                return hash;
            }

        }
    }
}
