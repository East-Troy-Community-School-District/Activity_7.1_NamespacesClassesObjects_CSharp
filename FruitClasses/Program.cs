/*
 * Fruit Classes
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss
 * the following questions...
 * 1. Why must we put Fruit in front of Apple and Banana when
 *    creating an object? What is the term for this style?
 * 2. What happens if we add this line of code to the top of the program?
 * 
 *    using Fruit;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit.Apple a = new Fruit.Apple("green");
            Console.WriteLine(a.Color);

            Fruit.Banana b = new Fruit.Banana();
            Console.WriteLine(b.Color);
            b.Ripen();
            Console.WriteLine(b.Color);
        }
    }
}

namespace Fruit
{
    public class Apple
    {
        /// <summary>
        /// Gets the apples color.
        /// </summary>
        public string Color { get; }

        /// <summary>
        /// Constructs a new Apple object.
        /// </summary>
        /// <param name="color">The color of the apple.</param>
        public Apple(String color)
        {
            Color = color;
        }
    }

    public class Banana
    {
        private string color;

        /// <summary>
        /// Get the color of the banana.
        /// </summary>
        public string Color {
            get
            {
                return color;
            }
        }

        /// <summary>
        /// Constructs a new Banana object.
        /// </summary>
        public Banana()
        {
            color = "yellow";
        }

        /// <summary>
        /// Ripens the banana.
        /// </summary>
        public void Ripen()
        {
            color = "brown";
        }
    }
}