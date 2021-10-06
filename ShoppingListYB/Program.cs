using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListYB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            string choice;

            //Grocery List Dictionary
            Dictionary<string, double> groceries = new Dictionary<string, double>();
            groceries.Add("Applesauce", 0.99);
            groceries.Add("Banana Bread", 0.59);
            groceries.Add("Cauliflower", 1.59);
            groceries.Add("Dragonfruit", 2.19);
            groceries.Add("Elderberry", 1.79);
            groceries.Add("Pineapple", 2.09);
            groceries.Add("Grapefruit", 1.99);
            groceries.Add("Honeydew", 3.49);

            //selection List
            List<string> selections = new List<string>();
            // prices List
            List<double> prices = new List<double>();
            //display menu and prices
            Console.WriteLine("Welcome to Yousif's Market!");
            Console.WriteLine("==============================");
            while (keepGoing)
            {
                while (true)
                {
                    foreach (KeyValuePair<string, double> kvp in groceries)
                    {
                        Console.WriteLine($" {kvp.Key}\t\t\t{kvp.Value}");
                    }
                    //ask for input
                    Console.WriteLine("Please enter an item name.");
                    choice = Console.ReadLine();
                    //validation

                    double itemCheck;

                    if (groceries.TryGetValue(choice, out itemCheck))
                    {
                        Console.WriteLine($"You have selected {choice} for {itemCheck}.");
                        selections.Add(choice);
                        prices.Add(groceries[choice]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("We are sorry. We do not have that, please select an item off of the menu.");
                        break;
                    }

                }
                while (true)
                {
                    Console.WriteLine("Would you like to add more items? (y/n)");
                    string moreItems = Console.ReadLine().ToLower();
                    if (moreItems == "n")
                    {
                        keepGoing = false;
                        break;
                    }
                    else if (moreItems == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not an option, would you like more items? (y/n)");
                    }
                }
            }
            Console.WriteLine("Thank you for shopping!");
            double average = prices.Average();
            for (int i = 0; i < selections.Count; i++)
            {
                Console.WriteLine($"{selections[i]}\t{prices[i]}");
            }
            Console.WriteLine($"The average prices of your items is: {average}");

        }
    }
}

