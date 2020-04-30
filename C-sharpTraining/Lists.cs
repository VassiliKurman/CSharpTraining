using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharpTraining
{
    /**
     * Code snippets taken from microsoft tutorials and modified
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
        }
    }
}