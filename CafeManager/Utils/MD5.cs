using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.Utils
{
    public static class MD5
    {
        public static string makeMD5(this string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }
    }
}
