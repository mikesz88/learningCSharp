namespace ForLoop
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter <= 20)
            {
                Console.WriteLine("Press Enter");
                char isEnter = Console.ReadKey().KeyChar;
                Console.WriteLine($"isEnter is: {isEnter}");
                if (isEnter.Equals((char)13))
                {
                    Console.WriteLine($"{counter} people have entered the bus");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Please only press enter.");
                }
                
            }
            Console.ReadKey();
        }


    }
}