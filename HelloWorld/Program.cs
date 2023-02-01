namespace HelloWorld
{
    internal class ClientActivity
    {

        public static void Main(string[] args)
        {
            /*
            SubString(int32) - is used to get the substring from the string, starting from the specified index.

            ToLower() - is used to convert the string to lowercase.

            ToUpper() - is used to convert the string to uppercase.

            Trim() - is used to trim all leading and trailing white space from the string.

            IndexOf(string) - is used to get the first occurance of the string or character inside the string

            IsNullOrWhiteSpace - returns true if the string is either null or is blank else it returns false.

            In C# the String.Format method is used to insert the object or variable value inside any string.
            With the String.Format we can replace the value in the specified format. 
            Syntax: String.Format("any string {index}", object);
            Example:
            string name = "Denis";
            string sentence = String.Format("My name is {0}", name);
            sentence now has a value of "My name is Denis";

            */

            /*string myName;
            Console.WriteLine("Please enter your name and press Enter");
            myName = Console.ReadLine();
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.Trim());
            Console.WriteLine(myName.Substring(3));*/

            /*Console.Write("Enter a string here: ");
            string newString = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            char newChar = Console.ReadLine()[0];
            int index = newString.IndexOf(newChar);
            Console.WriteLine($"The index of the character {newChar} in string {newString} is: {index}");
            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");*/

            byte smallNumber = 100;
            Console.WriteLine(smallNumber);
            sbyte sbyteNumber = -100;
            Console.WriteLine(sbyteNumber);
            int integer = 100000;
            Console.WriteLine(integer);
            uint unsignedInt = 4000000;
            Console.WriteLine(unsignedInt);
            short shortNum = -32000;
            Console.WriteLine(shortNum);
            ushort unsignedShortNum = 60000;
            Console.WriteLine(unsignedShortNum);
            long longNum = 9223372036854775807;
            Console.WriteLine(longNum);
            ulong unsignedLongNum = 18446744073709551615;
            Console.WriteLine(unsignedLongNum);
            float floatNum = -3.402823f;
            Console.WriteLine(floatNum);
            double doubleNum = 1.79769313486232;
            Console.WriteLine(doubleNum);
            char character = 'a';
            Console.WriteLine(character);
            bool boolNum = false;
            Console.WriteLine(boolNum);
            string stringTest = "test";
            Console.WriteLine(stringTest);
            decimal decimalNum = 1.5468687248725986752967529867259867568789567859678259067589m;
            Console.WriteLine(decimalNum);

            string string1 = "I control text";
            Console.WriteLine(string1);
            string string2 = "12";
            Console.WriteLine(int.Parse(string2));


        }
    }
}