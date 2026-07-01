namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task-1 create personal info cart 
            //string name = "Noora saif";
            //int age = 24;
            //double height = 1.53;
            //bool isStudent = false;

            //Console.Write("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + isStudent);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //task-2 create Rectangle calculator
            //Console.WriteLine("Enter the length of the rectangle: ");
            //double length = double.Parse (Console.ReadLine());

            //Console.WriteLine("Enter the width of the rectangle: ");
            //double width = double.Parse (Console.ReadLine());

            //double Area = length * width;
            //double Perimeter = 2 * (length + width);

            //Console.WriteLine("Area of the rectangle in meter: " + Area );
            //Console.WriteLine("Perimeter of the rectangle in sequere meter: " + Perimeter);
            /////////////////////////////////////////////////////////////////////////////////

            //task-3 Create Odd or Even Number Checker
            //Console.WriteLine("Enter a whole number: ");
            //double num = double.Parse (Console.ReadLine());

            //double result = num % 2;

            //if (result == 0)
            //{
            //    Console.WriteLine("Even number");
            //}
            //else if (result == 1)
            //{
            //    Console.WriteLine("Odd number");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number, please use only a whole number");
            //}
            ////////////////////////////////////////////////

            //Task-4 Create Voting Eligibility Checker
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse (Console.ReadLine());

            //Console.WriteLine("Do you have a valid national ID ? (yes/no): ");
            //string hasID = Console.ReadLine();

            //bool hasValidID = hasID == "yes";

            //if (age >= 18 && hasValidID == true)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else 
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}
            ///////////////////////////////////////////////////////////////////

            //Task-5 Grade letter lookup

            //Console.WriteLine("Grade Options:");
            //Console.WriteLine("A");
            //Console.WriteLine("B");
            //Console.WriteLine("C");
            //Console.WriteLine("D");
            //Console.WriteLine("F");

            //Console.WriteLine("Select a grade:");
            //char grade = char.Parse (Console.ReadLine());

            //switch (grade) 
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;
            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;
            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;
            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;

            //}
            //////////////////////////////////////////////////////////////

            //Task-6 Temperature Converter
            //Console.WriteLine("Enter the temperature in Celsius:");
            //double C = double.Parse (Console.ReadLine());

            //double F = (C * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + F);

            //if (C < 10) 
            //{
            //    Console.WriteLine("Cold");
            //}

            //else if (C >= 10 && C <= 30)
            //{
            //    Console.WriteLine("Mild");
            //}
            //else if (C > 30)
            //{
            //    Console.WriteLine("Hot");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid temperature");
            //}
            ////////////////////////////////////////////////////////////

            //Task-7 Movie Ticket Price Calculator
            //Console.WriteLine("Enter your age in year: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 12)
            //{
            //    Console.WriteLine("You are a child. and your ticket price is 2.000 OMR");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    Console.WriteLine("You are a Adults. and your ticket price is 5.000 OMR");
            //}
            //else if (age >= 60)
            //{
            //    Console.WriteLine("You are a Seniors. and your ticket price is 3.000 OMR");
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid age, please enter a valid age.");
            //}
            ////////////////////////////////////////////////////////////////////

            //Task-8 create Restaurant Bill Calculator with Membership Discount
            //Console.WriteLine("Enter your total bill amount");
            //double billAmount = double.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a loyalty member? (yes/no)");
            //string isloyal = Console.ReadLine();

            //bool loyalityMember = isloyal == "yes";

            //if (billAmount >= 20 && loyalityMember == true)
            //{
            //    double afterDiscount = billAmount - (billAmount * 0.15);
            //    Console.WriteLine("Your discount is 15%. Your final bill amount is: " + afterDiscount + " OMR");
            //}
            //else 
            //{
            //    Console.WriteLine("You do not have a discount. our final bill amount is: " + billAmount);
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Task-9 Day name finder
            Console.WriteLine("Enter number from 1 to 7 to represent the day of the week ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid number, please enter a number from 1 to 7.");
                    break;
            }
        }
    }
}
