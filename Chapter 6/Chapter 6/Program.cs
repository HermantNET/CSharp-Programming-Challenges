using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
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
            var menu = new ConsoleMenu.Menu();
            menu.Title = "C# Programming: Chapter 6";
            string[] options = { "Exercise 1", "Exercise 3", "Exercise 4", "Exercise 6", "Exercise 9", "EXIT" };
            menu.Options.AddRange(options);
            menu.MenuLoad();
        }
    }
}
