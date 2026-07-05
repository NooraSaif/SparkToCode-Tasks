namespace Task3Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1 Absolute Difference
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num2 - num1;
            Console.WriteLine($"The absolute difference between {num1} and {num2} is: {Math.Abs(result)}");

        }
    }
}
