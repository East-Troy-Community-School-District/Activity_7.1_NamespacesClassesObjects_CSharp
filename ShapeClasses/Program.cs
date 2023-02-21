/*
 * Shape Classes
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss
 * the following questions...
 * 1. How do the Rectangle and Circle classes belong to the same
 *    namespace?
 * 2. Based on this program, how should we structure our programs?
 * 
 * Together, let's modify the program by adding a Square class that
 * represents a square. Let's also make it part of the Shape
 * namespace. Finally, let's test the code in the Main() method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape.Rectangle r = new Shape.Rectangle(4, 7);
            Console.WriteLine(r.Length * r.Width);

            Shape.Circle c = new Shape.Circle(5);
            Console.WriteLine(Math.PI * Math.Pow(c.Radius, 2));

            // Add your code here!
        }
    }
}
