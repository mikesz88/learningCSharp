using ClassesBasics;
using System.Diagnostics.Metrics;

namespace Classes___Basics;

public class Program
{

    static void Main(string[] args)
    {
        // Create an object of my class
        // an instance of Human
        Human michael = new Human();
        // access public variable from outside, and even change it
        michael.firstName = "Michael";
        michael.lastName = "Sanchez";
        // call methods of the class
        michael.IntroduceMyself();

        Human lisa = new Human();
        lisa.firstName = "Lisa";
        lisa.lastName = "Sanchez";
        lisa.IntroduceMyself();


        Console.ReadKey();
    }

}