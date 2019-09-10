using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class LowerLetter : Letter
    {
        public LowerLetter(Random random) : base(random)
        {
        }
        public override string GetLetter()
        {
            return ((char)_random.Next(97, 123)).ToString();
        }
    }

}
