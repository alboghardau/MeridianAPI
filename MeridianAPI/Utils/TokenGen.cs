using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeridianAPI.Utils
{
    public class TokenGen
    {
        /// <summary>
        /// Generates random token
        /// </summary>
        /// <param name="length">Length of string to be return</param>
        public static string GenerateToken(int length)
        {
            Random random = new Random();

            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
