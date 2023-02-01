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

            Console.Write("Enter a string here: ");
            string newString = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            char newChar = Console.ReadLine()[0];
            int index = newString.IndexOf(newChar);
            Console.WriteLine($"The index of the character {newChar} in string {newString} is: {index}");
            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");


        }
    }
}