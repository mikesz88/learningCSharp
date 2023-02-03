namespace TryCatchFinally
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
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
            } finally
            {
                Console.WriteLine("This is called anyways!");
            };

            Console.ReadKey();
        }

    }
}