namespace EnhancedIfStatement
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // The conditional operator is right - associative.
            // The expression a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e),
            // not as (a ? b : c ) ? d : e.
            // The conditional operator cannot be overloaded.

            int temperature;
            Console.WriteLine("Please write the temperature");
            string tempString = Console.ReadLine()!;
            bool isANum = int.TryParse(tempString, out temperature);
            if (isANum)
            {
                checkTemp(temperature);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
            Console.ReadKey();
        }

        static void checkTemp(int temperature)
        {
            string message = temperature <= 15 
                ? "It is too cold here"
                : temperature > 28
                ? "It is too hot here"
                : "It is ok";
            Console.WriteLine(message);
        }



    }
}