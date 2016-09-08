using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Load();
        }

        internal static void Load() 
        {
            Console.Clear();
            var menu = new ConsoleMenu.Menu();
            menu.Title = "C# Programming: Chapter 5";
            string[] options = { "Exercise 1", "Exercise 2", "Exercise 3", "Exercise 4", "Exercise 6", "EXIT" };
            menu.Options.AddRange(options);
            menu.MenuLoad();
        }
    }
}
