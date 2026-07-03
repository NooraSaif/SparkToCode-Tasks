namespace Test2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1 Countdown Time
            Console.WriteLine("Enter a starting number");
            int startNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");


        }
    }
}
