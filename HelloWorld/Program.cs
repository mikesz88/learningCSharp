namespace ConstantsC
{
    internal class Program
    {
        const string name1 = "Michael";
        const string name2 = "Lisa";
        const string name3 = "Lily";

        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers());
            Console.WriteLine(Calculate());
            Console.Read();

        }

        public static double AddTwoNumbers()
        {
            Console.WriteLine("Please the first number");
            string num1 = Console.ReadLine()!;
            Console.WriteLine("Please the second number");
            string num2 = Console.ReadLine()!;
            double sum = double.Parse(num1) + double.Parse(num2);
            return sum;
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine()!;
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine()!;

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }

    }
}