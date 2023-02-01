namespace HelloWorld
{
    internal class ClientActivity
    {

        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            float floatedString = float.Parse(stringForFloat);
            string stringForInt = "12345"; // datatype should be int
            int intString = int.Parse(stringForInt);
        }
    }
}