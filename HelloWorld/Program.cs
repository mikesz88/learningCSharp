namespace ForLoop
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter <= 20; counter++)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(counter);
                }
            }
            Console.WriteLine("For loop is done");
            Console.ReadKey();
        }


    }
}