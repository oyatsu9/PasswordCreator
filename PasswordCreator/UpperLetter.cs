using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class UpperLetter : Letter
    {
        public UpperLetter(Random random) : base(random)
        {
        }
        public override string GetLetter()
        {
            return ((char)_random.Next(65, 91)).ToString();
        }
    }
}
