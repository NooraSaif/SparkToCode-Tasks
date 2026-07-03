namespace Test2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1 Countdown Time
            //Console.WriteLine("Enter a starting number");
            //int startNum = int.Parse(Console.ReadLine());

            //for (int i = startNum; i >=0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff!");
            /////////////////////////////////////////

            //Task-2 Sum of number 1 to N
            Console.WriteLine("Enter a positive whole number");
            int n = int.Parse(Console.ReadLine());

            int Sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Sum = Sum + i;
                Console.WriteLine(Sum);
            }
        }
    }
}
