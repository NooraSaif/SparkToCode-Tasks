using System.ComponentModel;

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
            //Console.WriteLine("Enter a positive whole number");
            //int n = int.Parse(Console.ReadLine());

            //int Sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    Sum = Sum + i;
            //    Console.WriteLine(Sum);
            //}
            ////////////////////////////////////////

            //Task-3 Mutiplication Table
            //Console.WriteLine("Enter a number");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    int result = n * i;
            //    Console.WriteLine(n + "*" + i + "=" + result);
            //}
            //////////////////////////////////////////

            //Task-4 passwored retry

            //string passwored = "Spark2026";

            //Console.WriteLine("Enter Your passwored");
            //string userInpute = Console.ReadLine();

            //while (passwored != userInpute)
            //{
            //    Console.WriteLine("Incorrect passwored, please try again");
            //    Console.WriteLine("Enter Your passwored");
            //    userInpute = Console.ReadLine();
            //}
            //Console.WriteLine("Access Granted");
            //////////////////////////////////////////////////////

            //Task-5 Number Guessing Game
            int secretNumber = 42;
            int userGuess;
            int counter = 0;

            do
            {
                Console.WriteLine("Enter your guess number");
                userGuess = int.Parse(Console.ReadLine());
                counter++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }

            } while (userGuess != secretNumber); 
            { 
                Console.WriteLine($"You guessed the number in {counter} attempts.");
            }
            
        }
    }
}
