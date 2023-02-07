namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                 Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Michael";

            switch (username)
            {
                case "Michael":
                    Console.WriteLine("Username is Michael");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;

            }


            Console.ReadKey();
        }





    }
}