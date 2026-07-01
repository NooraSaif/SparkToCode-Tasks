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
            Console.WriteLine("Enter your age: ");
            int age = int.Parse (Console.ReadLine());

            Console.WriteLine("Do you have a valid national ID ? (yes/no): ");
            string hasID = Console.ReadLine();

            bool hasValidID = hasID == "yes";

            if (age >= 18 && hasValidID == true)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else 
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            ///////////////////////////////////////////////////////////////////
            


        }
    }
}
