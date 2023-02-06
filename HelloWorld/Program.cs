namespace Coding.Exercise
{
    public class Exercise
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write a number.");
            string input = Console.ReadLine();
            int num;
            int.TryParse(input, out num);
            EvenOrOdd(num);
            Console.ReadKey();
        }

        public static void EvenOrOdd(int value)
        {
            bool result = value % 2 == 0;
            if (result)
            {
                Console.WriteLine("Even");
            } else
            {
                Console.WriteLine("Odd");
            }
        }

    }
}