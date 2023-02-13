namespace WhileLoop
{
    public class Exercise
    {

        static void Main(string[] args)
        {
            WhileLoop();
            ForLoop();
        }

        public static void ForLoop()
        {
            // TODO
            for (int i = -3; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            // TODO
            int i = 3;
            while (i >= -3)
            {
                Console.WriteLine(i);
                i--;
            }
        }

    }
}