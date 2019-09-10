using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class Shuffle
    {
        public static string Execute(string password)
        {
            var x = ' ';
            var res = string.Empty;
            var c = 0;
            char[] pws = password.ToArray();
            var random = new Random();
            while (c<password.Length)
            {
                var n = random.Next(password.Length);
                if (pws[n]!=x)
                {
                    res += pws[n];
                    pws[n] = x;
                    c++;

                }
            }
            return res;
        }
    }
}
