using System.Diagnostics.Metrics;

namespace HelloWorld;

public class Exercise
{

    static void Main(string[] args)
    {
        bool continueLoop = true;
        int counter = 0;
        float sum = 0;

        while (continueLoop)
        {
            Console.WriteLine("Please write a number");
            Console.WriteLine("Please write -1 when you are done.");
            string input = GetInput();
            float newNum;


            if (input == null || float.TryParse(input, out newNum) == false)
            {
                Console.WriteLine("Please provide a number.");
                continueLoop = true;
                continue;
            }

            float.TryParse(input, out newNum);

            if (newNum == -1)
            {
                float average = sum / counter;
                Console.WriteLine($"The average number is {average}");
                continueLoop = false;
                continue;
            }
            
            if (newNum < 0 || newNum > 20)
            {
                Console.WriteLine("The number must be between 0 and 20.");
                continueLoop = true;
                continue;
            }

            sum += newNum;
            counter++;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"counter is {counter}");
        }
        
    }

    public static string GetInput()
    {
        return Console.ReadLine();
        
    }

}