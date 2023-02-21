/*
 * T-Shirt Class
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss
 * the following questions...
 * 1. Why does line 34 print "TShirtClass.TShirt"? What does s2 actually represent?
 * 2. What can a class contain as members?
 * 3. How many TShirt objects can be created from the TShirt class?
 * 4. How are the name of classes formatted?
 * 
 * Modify the program by adding the code to create another TShirt object that
 * is a "x-large" and is "yellow". Call the Print() method to check your code!
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TShirt s1 = null;
            Console.WriteLine(s1);

            TShirt s2 = new TShirt("large", "green");
            Console.WriteLine(s2);
            s2.Print();

            // Add your code here!

        }
    }

    /// <summary>
    /// Represents a TShirt with a given size and color.
    /// </summary>
    public class TShirt
    {
        private string size;
        private string color;

        /// <summary>
        /// Constructs a TShirt object with a given size and color.
        /// </summary>
        /// <param name="size">The size of the t-shirt.</param>
        /// <param name="color">The color of the t-shirt.</param>
        public TShirt(string size, string color)
        {
            this.size = size;
            this.color = color;
        }

        /// <summary>
        /// Displays a summary of the t-shirt to the console.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Size: " + size + ", Color: " + color);
        }
    }
}
