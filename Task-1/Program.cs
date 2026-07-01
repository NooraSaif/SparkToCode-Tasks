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
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse (Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse (Console.ReadLine());

            double Area = length * width;
            double Perimeter = 2 * (length + width);

            Console.WriteLine("Area of the rectangle in meter: " + Area );
            Console.WriteLine("Perimeter of the rectangle in sequere meter: " + Perimeter);
            /////////////////////////////////////////////////////////////////////////////////


        }
    }
}
