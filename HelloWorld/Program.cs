namespace Coding.Exercise
{
    public class Exercise
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number");
            string stringAsNumber = Console.ReadLine()!;
            int num = int.Parse(stringAsNumber);
            NestedCheck(num);
        }
        static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            } 
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            } 
            else if (number % 2 == 1)
            {
                Console.WriteLine("Odd number.");
            } 
            else 
            {
                Console.WriteLine("Even number.");
            }


        }

    }
}