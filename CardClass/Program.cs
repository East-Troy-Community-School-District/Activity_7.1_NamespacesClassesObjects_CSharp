/*
 * Card Class
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss
 * the following questions...
 * 1. Where is the card class located? Is it in a namespace?
 * 2. What is an enumeration?
 * 
 * Modify the program by creating another card and printing it
 * to the console.
 * Together, we will modify the program by creating a new class
 * called UnoCard, which will represent an Uno card by storing
 * the color and face value of the card. As part of this class,
 * we will need to create two enumerations, one for the possible
 * colors and the other for possible face values, which will
 * be...
 * 1 - 9
 * Wild
 * Reverse
 * 
 * Let's test our class using the Main() method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Card c1 = new Card(rng);
            Console.WriteLine(c1);

            // Add your code here!

        }
    }
}
