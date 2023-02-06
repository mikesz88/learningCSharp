namespace TryCatchFinally
{
    class Program
    {

        static void Main(string[] args)
        {
            /*string numberAsString = "128";

            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);
            
            if (success)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            } else
            {
                Console.WriteLine("Parsing failed");
            }*/

            string numberAsString = "128.75xyz";

            float parsedValue;

            bool success = float.TryParse(numberAsString, out parsedValue);

            if (success)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }

            Console.ReadKey();
        }

    }
}