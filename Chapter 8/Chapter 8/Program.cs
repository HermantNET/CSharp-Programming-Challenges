using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Load();
        }

        public static void Load() 
        {
            Console.Clear();
            ConsoleMenu.Menu menu = new ConsoleMenu.Menu();
            menu.Title = "C# Programming: Chapter 8";
            string[] options = { "Exercise 4", "Exercise 7", "Exercise 8", "Exercise 10", "EXIT" };
            menu.Options.AddRange(options);
            menu.MenuLoad();
        }
    }
}
