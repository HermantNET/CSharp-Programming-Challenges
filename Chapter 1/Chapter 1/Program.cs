using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Program
    {
        // Application Entry Point
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            // Clear the console, render the menu
            Console.Clear();
            Console.WriteLine("C# Programming - Chapter 1\n" +
                              "-------------------------------------\n" +
                              " 1 - Exercise 1\n" +
                              " 2 - Exercise 2\n" +
                              " 3 - Exercise 3\n" +
                              " 4 - Exercise 4\n" +
                              " 5 - Exercise 5\n" +
                              " 8 - Exercise 8\n" +
                              " 9 - Exercise 9\n\n" +
                              " exit - Close Application\n\n\n" +
                              "Input:\n");
            
            menuExercises();
        }

        static void menuExercises()
        {
            // Based on users input, decide on what to do
            var arg = Console.ReadLine();
            switch (arg)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "8":
                case "9":
                    menuOption(Exercises.Exercise, int.Parse(arg));
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    menuExercises();
                    break;
            }
        }

        // Takes a function as the argument, supplying the excercise number as the second argument. Calls the function with 'excercise' number arg.
        static void menuOption(Action<int> func, int exercise)
        {
            Console.Clear();
            func(exercise);
            Console.WriteLine("\nType 'menu' to return to menu.");
            Exercises.Options();
        }
    }
}
