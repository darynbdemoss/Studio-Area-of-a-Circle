using System;

namespace Studio_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;

            Console.WriteLine($"\nFor a circle with a radius of {radius}");
            Console.WriteLine($"The area is: {area}");
            Console.WriteLine($"The circumference is: {circumference}");
            Console.WriteLine($"The diameter is: {diameter}");

            Console.WriteLine("\nWhats your car's MPG: ");
            double mpg = double.Parse(Console.ReadLine());

            double gallonsUsed = (1 / mpg) * circumference;
            Console.WriteLine($"You need {gallonsUsed} gallons to go around the circle");
        }
    }
}
