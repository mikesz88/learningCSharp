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
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // constructor
        public Human(string firstName, string myLastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            lastName = myLastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}. My eye color is {eyeColor} and I am {age} years old");
        }
    }
}
