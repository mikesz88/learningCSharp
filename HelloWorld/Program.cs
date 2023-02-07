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

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 110;

            // in short
            stateOfMatter = temperature < 0 ? "solid" : temperature > 100 ? "gas" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();
        }



    }
}