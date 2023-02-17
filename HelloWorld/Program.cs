using ClassesBasics;
using System.Diagnostics.Metrics;

namespace Classes___Basics;

public class Program
{

    static void Main(string[] args)
    {
        Human michael = new Human("Michael", "Sanchez", "brown", 34);
        michael.IntroduceMyself();

        Human lisa = new Human("Lisa", "Sanchez", "brown", 33);
        lisa.IntroduceMyself();


        Console.ReadKey();
    }

}