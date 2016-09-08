using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3
{
    class Program
    {
        static void Main()
        {
            Load();
        }

        public static void Load() 
        {
            Console.Clear();
            ConsoleMenu.Menu menu = new ConsoleMenu.Menu();
            menu.Title = "C# Programming: Chapter 3";

            string[] options = { "Exercise 1", "Exercise 3", "Exercise 5", "Exercise 6", "Exercise 7", "EXIT" };
            menu.Options.AddRange(options);

            menu.MenuLoad();
        }
    }
}
