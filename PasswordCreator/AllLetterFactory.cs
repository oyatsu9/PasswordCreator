using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class AllLetterFactory:ILetterFactory
    {
        public  Letter Create(Random random,int i)
        {
            var n = i % 4;
            if (n == 0) return new NumLetter(random);
            if (n == 1) return new LowerLetter(random);
            if (n == 2) return new UpperLetter(random);
            if (n == 3) return new MakeLetter(random);
            return null;
        }
    }
}
