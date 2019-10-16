using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool set = true;
            Console.WriteLine("Enter a shape whose area is required\n1.Square\n2.Rectangle\n3.Triangle\n4.Circle\n");
            while (set)
            {
                 choice = Console.ReadLine();
                if (choice.ToLower() != "square" && choice.ToLower() != "rectangle" && choice.ToLower() != "triangle" && choice.ToLower() != "circle")
                    Console.WriteLine("Enter a valid option");
                else
                    set = false;
            }
            switch (choice)
            {
                case "square": 
                    Console.WriteLine("Enter the side (in cm)");
                    double side = int.Parse(Console.ReadLine());
                    Shapes square = new Shapes(side);
                    Console.WriteLine("Area is "+square.getArea() + " cm2");
                    break;
                case "rectangle":
                    Console.WriteLine("Enter the length (in cm)");
                    double length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width (in cm)");
                    double width = int.Parse(Console.ReadLine());
                    Shapes rectangle = new Shapes(length, width);
                    Console.WriteLine("Area is "+rectangle.getArea() + " cm2");
                    break;
                case "triangle":
                    Console.WriteLine("Enter the height (in cm)");
                    double height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the base (in cm)");
                    double Base = int.Parse(Console.ReadLine());
                    Shapes triangle = new Shapes(height, Base, "triangle");
                    Console.WriteLine("Area is "+triangle.getArea() +" cm2");
                    break;
                case "circle":
                    Console.WriteLine("Enter the radius (in cm)");
                    double radius = int.Parse(Console.ReadLine());
                    Shapes circle = new Shapes(radius, "circle");
                    Console.WriteLine("Area is "+circle.getArea() + " cm2");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadKey();
        }
    }
}
