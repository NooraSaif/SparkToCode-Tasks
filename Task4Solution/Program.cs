using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
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

        //Task 5 - Even or Odd Function
        // bool return and one int parameter
        public static bool IsEven(int number) 
        {
            return number % 2 == 0;
        }

        //Task 6 - Rectangle Area &Perimeter Functions
        //double return and two double parameters
        public static double CalculateArea(double width, double lenght)
        {
            return width * lenght;
        }
        public static double CalculatePerimeter(double width, double lenght)
        {
            return 2 * (width + lenght);
        }

        //Task 7 - Grade Letter Function
        //string return and one int parameter
        public static string GetGradeLetter(int grade)
        {
            if (grade < 0)
            {
                return "Invalid grade";
            }
            else if (grade >= 90)
            {
                return "A";

            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void Main(string[] args)
        {
            ////Task 1 - Personalized Welcome Functio
            //Console.WriteLine("Enter your name:");
            //string userName = Console.ReadLine();

            //// call PrintWelcome function
            //PrintWelcome(userName);
            /////////////////////////////////////////////////////////

            ////Task 2 - Square Number Function
            //Console.WriteLine("Enter a whole number to square:");
            //int num = Convert.ToInt16(Console.ReadLine());

            //// call Square function
            //int result = Square(num);
            //Console.WriteLine($"The square of {num} is: " + result);
            /////////////////////////////////////////////////////////

            ////Task 3 - Celsius to Fahrenheit Function
            //Console.WriteLine("Enter the temperature in Celsius:");
            //double celsiuseNumber = Convert.ToDouble(Console.ReadLine());

            //// call CelsiusToFahrenheit function
            //double fahrenheitResult = CelsiusToFahrenheit(celsiuseNumber);
            //Console.WriteLine($"{celsiuseNumber} Celsius is equal to {fahrenheitResult} Fahrenheit.");
            /////////////////////////////////////////////////////////////////////////////////////////////

            ////Task 4 - Fixed Menu Display Function
            ////call DisplayMenu function
            //DisplayMenu();
            ////////////////////////////////////////////////////////

            //Task 5 - Even or Odd Function
            //Console.WriteLine("Enter a whole number to check if it is even:");
            //int userNumber = Convert.ToInt16(Console.ReadLine());

            ////call IsEven function
            //if (IsEven(userNumber) == true)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}
            //////////////////////////////////////////////////////////

            ////Task 6 - Rectangle Area & Perimeter Functions
            //Console.WriteLine("Enter the width of the rectangle:");
            //double width = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the length of the rectangle:");
            //double length = Convert.ToDouble(Console.ReadLine());

            //// call CalculateArea and CalculatePerimeter functions and display the results
            //Console.WriteLine($"The area of the rectangle is: {CalculateArea(width, length)}");
            //Console.WriteLine($"The perimeter of the rectangle is: {CalculatePerimeter(width, length)}");
            /////////////////////////////////////////////////////////////////////////////////////////

            //Task 7 - Grade Letter Function
            Console.WriteLine("Enter your score:");
            int userScore = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Your grade letter is: {GetGradeLetter(userScore)}");
            ////////////////////////////////////////////////////////////////////////
            

        }
    }
}
