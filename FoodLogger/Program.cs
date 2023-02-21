/*
 * T-Shirt Class
 * 2/20/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program to see what it does. Be prepared to discuss
 * the following questions...
 * 1. What happens if you change the access modify of the FoodItem
 *    class from public to private?
 * 2. How is an array declared to store objects?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            int items;
            FoodItem[] foodItems;
            Console.Write("How many items did you eat? >> ");
            items = Convert.ToInt32(Console.ReadLine());
            foodItems = new FoodItem[items];
            for(int i = 0; i < foodItems.Length; i++)
            {
                int calories;
                string name;
                Console.Write("Enter the name of an item >> ");
                name = Console.ReadLine();
                Console.Write("Enter the calories in the item >> ");
                calories = Convert.ToInt32(Console.ReadLine());
                foodItems[i] = new FoodItem(name, calories);
            }
            Console.WriteLine("You ate a total of " 
                + TotalCalories(foodItems) + " calories.");
        }

        /// <summary>
        /// Calculates the total calories of all the food items.
        /// </summary>
        /// <param name="items">List of food items eaten.</param>
        /// <returns>Returns the total calories in all the food items.</returns>
        private static int TotalCalories(FoodItem[] items)
        {
            int totalCalories = 0;
            foreach(FoodItem item in items)
            {
                totalCalories += item.Calories;
            }
            return totalCalories;
        }
    }

    public class FoodItem
    {
        /// <summary>
        /// Gets the name of the food item.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the calories of the food item.
        /// </summary>
        public int Calories { get; }
        
        /// <summary>
        /// Constructs a new FoodItem object.
        /// </summary>
        /// <param name="name">The name of the food item.</param>
        /// <param name="calories">The calories in the food item.</param>
        public FoodItem(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }
    }
}
