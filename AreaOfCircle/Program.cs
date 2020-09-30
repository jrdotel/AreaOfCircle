using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double pi;
            double r;
            double area;
            double circumference;
            double diameter;

            Console.WriteLine("Enter the radius of the circle: ");
            input = Console.ReadLine();
            pi = 3.14;
            r = double.Parse(input);
            area = (pi * r * r);
            circumference = (2 * pi * r);
            diameter = (2 * r);

            Console.WriteLine("The area of a circle of radius " + r + " is: " + area);
            Console.WriteLine("The circumference of a circle of radius " + r + " is: " + circumference);
            Console.WriteLine("The are of a diameter of radius " + r + " is: " + diameter);
        }
    }
}
