using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class Letter
    {
        protected Random _random;
        public Letter(Random random)
        {
            _random = random;

        }
       public virtual string GetLetter()
        {
            return string.Empty;
        }
    }
}
