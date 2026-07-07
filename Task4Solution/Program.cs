using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4Solution
{
    internal class Program
    {
        //Task 1 - Personalized Welcome Functio
        public static void PrintWelcome(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        //Task 2 - Square Number Function
        public static int Square(int number) 
        {
            return number * number;
        }

        //Task 3 - Celsius to Fahrenheit Function
        public static double CelsiusToFahrenheit(double celsiuse)
        {
            return (celsiuse * 9 / 5) + 32;
        }

        //Task 4 - Fixed Menu Display Function
        public static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Exit");
        }

        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Functio
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            // call PrintWelcome function
            PrintWelcome(userName);
            ///////////////////////////////////////////////////////

            //Task 2 - Square Number Function
            Console.WriteLine("Enter a whole number to square:");
            int num = Convert.ToInt16(Console.ReadLine());

            // call Square function
            int result = Square(num);
            Console.WriteLine($"The square of {num} is: " + result);
            ///////////////////////////////////////////////////////

            //Task 3 - Celsius to Fahrenheit Function
            Console.WriteLine("Enter the temperature in Celsius:");
            double celsiuseNumber = Convert.ToDouble(Console.ReadLine());

            // call CelsiusToFahrenheit function
            double fahrenheitResult = CelsiusToFahrenheit(celsiuseNumber);
            Console.WriteLine($"{celsiuseNumber} Celsius is equal to {fahrenheitResult} Fahrenheit.");
            ///////////////////////////////////////////////////////////////////////////////////////////

            //Task 4 - Fixed Menu Display Function
            //call DisplayMenu function
            DisplayMenu();
            ////////////////////////////////////////////////////////
        }
    }
}
