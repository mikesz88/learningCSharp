namespace Coding.Exercise
{
    public class Exercise
    {
        static string username, password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadKey();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine()!;
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine()!;
            Console.WriteLine("Registration Completed");
            Console.WriteLine("-----------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {

            Console.WriteLine("Login failed, wrong password. Restart Program");
            }
        }


    }
}