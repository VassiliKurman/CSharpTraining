using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharpTraining
{
    /**
     * Code snippets taken from microsoft tutorials and modified.
     * "System.Diagnostics.Debug.WriteLine()" is used instead of "Console.WriteLine()" to see
     * output in the debug mode, due to well known issue with Console view in Visual Studio.
    */
    class Lists
    {
        public static void ListOperations()
        {
            // Creating list and printing every element in upper case using string interpolation
            System.Diagnostics.Debug.WriteLine("--- Creating list ---");
            var names = new List<string> { "Vassili", "Ana", "Felipe" };
            foreach (var name in names)
            {
                System.Diagnostics.Debug.WriteLine($"Hello {name.ToUpper()}!");
            }

            // Adding and removing items to the list
            System.Diagnostics.Debug.WriteLine("--- Updating list ---");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Felipe");
            foreach (var name in names)
            {
                System.Diagnostics.Debug.WriteLine($"Hello {name.ToUpper()}!");
            }

            // Referencing individual items by index
            System.Diagnostics.Debug.WriteLine("--- Referencing items by index ---");
            System.Diagnostics.Debug.WriteLine($"My name is {names[0]}.");
            System.Diagnostics.Debug.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            // Checking the list size using Count property
            System.Diagnostics.Debug.WriteLine($"The list has {names.Count} people in it");

            // Searching for item in the list
            var index = names.IndexOf("Maria");
            if (index != -1)
                System.Diagnostics.Debug.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            System.Diagnostics.Debug.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            // Sorting items in the list. This will modify existing list
            names.Sort();
            foreach (var name in names)
            {
                System.Diagnostics.Debug.WriteLine($"Hello {name.ToUpper()}!");
            }

            // Challenge to create Fibonacci Numbers
            System.Diagnostics.Debug.WriteLine("--- Building list of Fibonacci numbers ---");
            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                System.Diagnostics.Debug.WriteLine(item);
        }
    }
}