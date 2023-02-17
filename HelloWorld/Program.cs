using ClassesBasics;
using System.Diagnostics.Metrics;

namespace Classes___Basics;

public class Program
{

    static void Main(string[] args)
    {
        Human michael = new Human("Michael", "Sanchez", "brown", 34);
        michael.IntroduceMyself();

        Human lisa = new Human("Lisa", "Sanchez", "brown");
        lisa.IntroduceMyself();

        Human basicHuman = new Human();
        basicHuman.IntroduceMyself();

        Human someHuman = new Human("Some", "Human");
        someHuman.IntroduceMyself();

        Human firstHuman = new Human("firstHuman");
        firstHuman.IntroduceMyself();

        Console.ReadKey();
    }

}