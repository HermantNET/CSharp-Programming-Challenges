using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter_3.Exercises;

namespace ConsoleMenu
{
    class ExercisesHandler
    {
        public static void ExerciseHandler(string currentSelection)
        {
            ExerciseOptions options = new ExerciseOptions();

            Console.Clear();
            // This is where you add your options. Cases must match the parameters you pass to Menu.Options, else the application will default to exit.
            switch (currentSelection) 
            {
                case "Exercise 1":
                    if (true) 
                    {
                        Exercise_1 exercise = new Exercise_1();
                        exercise.schoolName = "Suncoast Technical College";
                        exercise.schoolDesc = "A solid technical school located in Sarasota, Florida. They offer a great programming course called .NET Applications!";
                        exercise.schoolColors.Add("Blue");
                        exercise.schoolColors.Add("White");
                        exercise.Run();
                    }
                   
                    break;
                case "Exercise 3":
                    if (true)
                    {
                        Exercise_3 exercise = new Exercise_3();
                        exercise.Run();
                    }
                    break;
                case "Exercise 5":
                    if (true)
                    {
                        Exercise_5 exercise = new Exercise_5();
                        exercise.Run();
                    }
                    break;
                case "Exercise 6":
                    if (true)
                    {
                        Exercise_6 exercise = new Exercise_6();
                        exercise.Run();
                    }
                    break;
                case "Exercise 7":
                    if (true)
                    {
                        Exercise_7 exercise = new Exercise_7();
                        exercise.Run();
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            options.Options(currentSelection);
        }
    }

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
                    Chapter_3.Program.Load();
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

    // This is to keep implementation readable. You do not have to inherit from this class, especially if it does not make sense to do so.
    abstract class Exercise 
    {
        public abstract void Run();
    }
}
