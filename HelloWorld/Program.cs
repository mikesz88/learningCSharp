namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            string username, password;
            string[] credentials = new string[2];
            credentials = registerUser();

            username= credentials[0];
            password= credentials[1];

            bool loginStatus = loginUser(username, password);
            
            if (loginStatus)
            {
                Console.WriteLine("You are logged in");
            }
            else
            {
                Console.WriteLine("Invalid Username and Password");
            }



        }

        static string[] registerUser()
        {
            Console.WriteLine("What username would you like?");
            string username = Console.ReadLine()!;
            Console.WriteLine("What password would you like?");
            string password = Console.ReadLine()!;
            string[] credentials = new string[2] { username, password };
            return credentials;
        }

        static bool loginUser(string username, string password)
        {
            Console.WriteLine("Please login by writing your username and password ");
            Console.WriteLine("Username: ");
            string attemptedUsername = Console.ReadLine()!;
            Console.WriteLine("Password: ");
            string attemptedPassword = Console.ReadLine()!;
            if (attemptedUsername.Equals(username) && attemptedPassword.Equals(password))
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}