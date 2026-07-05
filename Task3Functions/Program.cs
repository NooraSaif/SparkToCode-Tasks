namespace Task3Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1 Absolute Difference
            //Console.WriteLine("Enter the first number: ");
            //int num1 = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int result = num2 - num1;
            //Console.WriteLine($"The absolute difference between {num1} and {num2} is: {Math.Abs(result)}");
            ////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 2 - Power & Root Explorer
            //Console.WriteLine("Enter a number: ");
            //double num = Convert.ToInt32(Console.ReadLine());

            //double result1 = Math.Pow(num, 2);
            //double result2 = Math.Sqrt(num);

            //Console.WriteLine($"The square of {num} is: {result1}");
            //Console.WriteLine($"The square root of {num} is: {result2}");
            ///////////////////////////////////////////////////////////////

            //Task 3 - Name Formatter
            Console.WriteLine("Enter your full name: ");
            string UserName = Console.ReadLine();

            Console.WriteLine("Your name in uppercase: " + UserName.ToUpper());
            Console.WriteLine("Your name in lowercase: " + UserName.ToLower());
            Console.WriteLine("the number of characters in your name is: " + UserName.Length);
            //////////////////////////////////////////////////////
            

        }
    }
}
