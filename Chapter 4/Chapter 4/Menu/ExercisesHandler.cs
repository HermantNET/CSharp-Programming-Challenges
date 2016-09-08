using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    class ExercisesHandler
    {
        public static void ExerciseHandler(string currentSelection)
        {
            ExerciseOptions options = new ExerciseOptions();
            dynamic dynamic_ex;

            Console.Clear();
            // This is where you add your options. Cases must match the parameters you pass to Menu.Options, else the application will default to exit.
            switch (currentSelection) 
            {
                case "Exercise 1":
                    dynamic_ex = new Chapter_4.Exercises.Exercise_1.Exercise();
                    dynamic_ex.Run();
                    break;
                case "Exercise 3":
                    dynamic_ex = new Chapter_4.Exercises.Exercise_3.Exercise();
                    dynamic_ex.Run();
                    break;
                case "Exercise 5":
                    dynamic_ex = new Chapter_4.Exercises.Exercise_5.Exercise();
                    dynamic_ex.Run();
                    break;
                case "Exercise 6":
                    dynamic_ex = new Chapter_4.Exercises.Exercise_6.Exercise();
                    dynamic_ex.Run();
                    break;
                case "Exercise 7":
                    dynamic_ex = new Chapter_4.Exercises.Exercise_7.Exercise();
                    dynamic_ex.Run();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            options.Options(currentSelection);
        }
    }
}
