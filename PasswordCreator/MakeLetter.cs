using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator
{
    public class MakeLetter : Letter
    {
        public MakeLetter(Random random) : base(random)
        {
        }
        public override string GetLetter()
        {
            string[] marks = { "!", "#", "$", "%", "&", "@" };
            return marks[_random.Next(marks.Length)];
        }
    }
}
