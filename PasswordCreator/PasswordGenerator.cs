using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class PasswordGenerator
    {
        private Random _random;
        public PasswordGenerator(Random random)
        {
            _random = random;
        }
        public string MakePassword(int count,ILetterFactory factory)
        {
            var password = string.Empty;
            for(var i = 0; i < count; i++)
            {
                
                Letter letter = factory.Create(_random, i);
                password += letter.GetLetter();
            }
            
            return Shuffle
                .Execute(password);
        }

    }
}
