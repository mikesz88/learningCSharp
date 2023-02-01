namespace HelloWorld
{
    internal class ClientActivity
    {

        static void Main(string[] args)
        {
            // implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString(); // "13.37"
            string myStringFloat = myFloat.ToString();
            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myString);
            Console.WriteLine(myStringFloat);
            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}