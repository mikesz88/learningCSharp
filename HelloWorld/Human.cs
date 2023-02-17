using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        public string firstName;

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {firstName}");
        }
    }
}
