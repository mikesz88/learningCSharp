namespace ConstantsC
{
    internal class Program
    {
        const string name1 = "Michael";
        const string name2 = "Lisa";
        const string name3 = "Lily";

        static void Main(string[] args)
        {
            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
            Console.Read();
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine($"Hi {name}, my friend!");
        }

    }
}