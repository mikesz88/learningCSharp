using ClassesBasics;
using System.Diagnostics.Metrics;

namespace Classes___Basics;

public class Program
{

    static void Main(string[] args)
    {
        Human michael = new Human("Michael", "Sanchez");
        michael.IntroduceMyself();

        Human lisa = new Human("Lisa", "Sanchez");
        lisa.IntroduceMyself();


        Console.ReadKey();
    }

}