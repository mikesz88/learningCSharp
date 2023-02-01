namespace ConstantsC
{
        // Constants are immutable values which are known
        // at compile time and do not change for the life of the program.
    internal class Program
    {
        // constants fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        // Create a constant of type string with your birthday as its value
        const string myBirthday = "07/28/1988";
        public static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always going to be {myBirthday}");
            Console.Read();

        }
    }
}