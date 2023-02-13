namespace HelloWorld;

public class Exercise
{

    static void Main(string[] args)
    {

            int i = -10;

            while (i < 10)
            {

                // TODO
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i % 6 == 0)
                {
                    break;
                }
                Console.WriteLine(i++);
            }
    }

}