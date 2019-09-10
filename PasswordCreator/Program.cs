using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 12;
            var random = new Random();
            ILetterFactory factory = new AllLetterFactory();
            PasswordGenerator generator = new PasswordGenerator(random);
            var password = generator.MakePassword(count,factory);
            Console.WriteLine(password);

        }
    }
}
