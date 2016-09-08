using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2
{
    class Program
    {
        // Application entry point
        static void Main(string[] args)
        {
            
            Menu();
        }

        // Menu to be printed
        public static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("C# Programming Chapter 2\n" +
                              "------------------------\n" +
                              " 3 - Exercise 3\n" +
                              " 4 - Exercise 4\n" +
                              " 5 - Exercise 5\n" +
                              " 10 - Exercise 10\n\n" +
                              " exit - Close Application\n\n" +
                              "Execute: ");
            Options();
        }

        static void Options()
        {
            string choice = Console.ReadLine();
            switch (choice) 
            {
                case "3":
                case "4":
                case "5":
                case "10":
                    Console.Clear();
                    Exercises.exercise(int.Parse(choice));
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    Options();
                    break;
            }
        }
    }
}
