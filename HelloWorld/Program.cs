namespace TryCatchFinally
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;


            // unary operator
            num3 = -num1; // adding a '-' sign multiplies it by -1.
            Console.WriteLine($"num3 is {num3}");


            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}"); // Adding an exclamation gives opposite value.

            // increment operators
            int num = 0;
            num++; // increases it by one.
            Console.WriteLine($"num is {num}");
            Console.WriteLine($"num is {num++}"); // This is does not change it on the current line. Only after it because ++ is after the variable. 
            // post increment is what it is called. 
            Console.WriteLine($"num is {++num}"); // This changes it prior to calling it because ++ is before the variable
            // pre increment is what it is called.

            // decrement operator
            num--;
            Console.WriteLine($"num is {num}");
            Console.WriteLine($"num is {num--}"); 
            Console.WriteLine($"num is {--num}");

            // Math operators
            int result;
            result = num1 + num2;
            Console.WriteLine($"result of num1 + num2 is: {result}");

            result = num1 - num2;
            Console.WriteLine($"result of num1 - num2 is: {result}");

            result = num1 * num2;
            Console.WriteLine($"result of num1 * num2 is: {result}");

            result = num1 / num2;
            Console.WriteLine($"result of num1 / num2 is: {result}");

            result = num1 % num2;
            Console.WriteLine($"result of num1 % num2 is: {result}");

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine($"result of num1 < num2 is: {isLower}");

            isLower = num1 > num2;
            Console.WriteLine($"result of num1 > num2 is: {isLower}");

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine($"result of num1 == num2 is: {isEqual}");

            isEqual = num1 != num2;
            Console.WriteLine($"result of num1 != num2 is: {isEqual}");

            // Conditional operators
            bool isLowerAndSunny;
            // condition 1 AND condition 2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine($"result of isLower && isSunny is: {isLowerAndSunny}");

            // condition 1 OR condition 2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine($"result of isLower || isSunny is: {isLowerAndSunny}");


            Console.ReadKey();
        }

    }
}