/*
 * Making Objects
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss the following
 * questions...
 * 1. What happens if you delete line 33? Why?
 * 2. On line 39 and line 43, we use something called dot notation. What
 *    is the purpose of dot notation?
 * 3. What does a DateTime object represent?
 * 4. What does null mean?
 * 
 * Finally, create a DateTime object representing your birthday.
 * Print the object to the console to confirm that your code works.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // All variables previously discussed are objects!
            Int32 i;
            i = new Int32();
            Console.WriteLine(i);

            String s = "Strings are technically objects!";
            String blank = null;
            Console.WriteLine(s);
            Console.WriteLine(s.ToLower());
            Console.WriteLine(blank);

            DateTime mrPBirthday = new DateTime(1994, 10, 31);
            Console.WriteLine("Mr. Pawelski's birthday is on " + mrPBirthday.ToString("d"));

            DateTime today = DateTime.Now;
            Console.WriteLine("It is currently " + today);

            // Add your code here!

        }
    }
}
