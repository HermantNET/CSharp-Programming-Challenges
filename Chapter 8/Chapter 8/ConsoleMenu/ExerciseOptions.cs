using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class ExerciseOptions
    {
        public void Options(string selection)
        {
            Console.WriteLine("\nType 'menu' to return to the menu, 'help' to display available commands.");
            Commands(selection);
        }

        private void Commands(string selection)
        {
            switch (Console.ReadLine())
            {
                case "menu":
                    Chapter_8.Program.Load();
                    break;
                case "rerun":
                    ExercisesHandler.ExerciseHandler(selection);
                    break;
                case "help":
                    Console.WriteLine(" 'menu' - Return to menu\n 'rerun' - Run the last selected item\n 'help' - Displays available commands\n 'exit' - Closes the application");
                    Commands(selection);
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    Commands(selection);
                    break;
            }
        }
    }
}
