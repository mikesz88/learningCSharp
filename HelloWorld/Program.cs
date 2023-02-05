namespace TryCatchFinally
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
            /*Console.WriteLine("Please enter a number!");
            string input = Console.ReadLine()!;
            try
            {
                int userInputAsInt = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too shor for an int32.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, ThreadExceptionEventArgs values was empty (Null)");
            } 
            finally
            {
                Console.WriteLine("This is called anyways!");
            };*/

            Console.ReadKey();
        }

    }
}