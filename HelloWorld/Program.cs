namespace TryCatchFinally
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature like?");
            string temperatureString;
            temperatureString = Console.ReadLine()!;
            int temperature;
            int number;

            if (int.TryParse(temperatureString, out number)) 
            { 
                temperature = number;
            } else
            {
                temperature = 0;
                Console.WriteLine("Value entered, was not a number. 0 set as a temparature");
            }

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