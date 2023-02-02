namespace ConstantsC
{
    internal class Program
    {
        const string name1 = "Michael";
        const string name2 = "Lisa";
        const string name3 = "Lily";

        static void Main(string[] args)
        {
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }

        public static string LowUpper(string s)
        {
            string lower = s.ToLower();
            string upper = s.ToUpper();
            string lowerUpper = lower + upper;
            return lowerUpper;
        }

        public static void Count(string s) 
        {
            Console.WriteLine($"The amount of characters is {s.Length}.");
        }

    }
}