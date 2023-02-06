namespace TryCatchFinally
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature like?");
            string temperatureString;
            temperatureString = Console.ReadLine()!;
            int temperature= Int32.Parse(temperatureString);
            if (temperature < 50)
            {
                Console.WriteLine("Take the coat");
            } else if (temperature > 50)
            {
                Console.WriteLine("Beach Weather!");
            } else
            {
                Console.WriteLine($"It is {temperature} degrees Farenheit");
            }

            Console.ReadKey();
        }

    }
}