﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class NonMarkLetterFactory:ILetterFactory
    {
        public  Letter Create(Random random,int i)
        {
            var n = i % 3;
            if (n == 0) return new NumLetter(random);
            if (n == 1) return new LowerLetter(random);
            if (n == 2) return new UpperLetter(random);
            return null;
        }
    }
}
