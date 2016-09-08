using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_2
{
    class Exercises
    {
        internal static void exercise(int num)
        {
            switch (num)
            {
                case 3:
                    Exercise_3.Run();
                    break;
                case 4:
                    Exercise_4.Run();
                    break;
                case 5:
                    Exercise_5.Run();
                    break;
                case 10:
                    Exercise_10.Run();
                    break;
            }
            Console.WriteLine("\nType 'menu' to return to the menu, 'exit' to close the application.");
            Options();
        }

        static void Options()
        {
            switch (Console.ReadLine())
            {
                case "menu":
                    Program.Menu();
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

    class Exercise_3
    {
        internal static double convert(double f)
        {
            return (f - 32) * 5 / 9;
        }

        internal static void print(double f)
        {
            double c = convert(f);
            Console.WriteLine(" - F: {0}\n - C: {1}\n", f, c);
        }

        internal static void Run()
        {
            Console.WriteLine("Fahrenheit to Celsius\n\n");
            print(87);
            Console.Write("Enter Fahrenheit: ");
            try
            {
                print(double.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Invalid Input.");
            }
        }
    }

    class Exercise_4
    {
        static void print(string title, decimal value, int a, float b, double c, decimal d) 
        {
            Console.WriteLine(title + "\n");
            Console.WriteLine("Value: {0}\n", value);
            Console.WriteLine(" - int: {0:c}\n - float: {1:c}\n - double: {2:c}\n - decimal: {3:c}\n", a, b, c, d);
        }

        internal static void Run()
        {
            const decimal num1 = 0.99M;
            const decimal num2 = 0.45554M;

            int a = 0;
            float b = 0;
            double c = 0;
            decimal d = 0;

            Console.WriteLine("Value Type Demo\n\n");
            print("No Value: ", 0, a, b, c, d);

            a = (int)num1;
            b = (float)num1;
            c = (double)num1;
            d = num1;

            print("Two Digits: ", num1, a, b, c, d);

            a = (int)num2;
            b = (float)num2;
            c = (double)num2;
            d = num2;

            print("Five Digits: ", num2, a, b, c, d);
        }
    }

    class Exercise_5
    {
        static void print(string name, decimal ss, decimal tr, decimal cr, decimal rp, decimal sw) 
        {
            decimal takeHome = sw * (ss + tr + cr + rp);

            Console.WriteLine("\nEmployee: {0}\nSales This Week: {1:c}\n - Commission Rate: {2:0.0%}\n - Tax Rate: {3:0.0%}\n" +
                              " - Social Security: {4:0.0%}\n - Retirement Plan: {5:0.0%}\n\nTake Home: {6:c}\n", name, sw, cr, tr, ss, rp, takeHome);
        }

        internal static void Run()
        {
            // Employee
            string employeeName = "Jessica Oakley";

            // Constants
            const decimal socialSecurity = 0.06M;
            const decimal taxRate = 0.18M;

            // Variable
            decimal commissionRate = 0.07M;
            decimal retirementPlan = 0.1M;
            decimal salesWeek = 28000;

            Console.WriteLine("Take-Home Pay\n");
            print(employeeName, socialSecurity, taxRate, commissionRate, retirementPlan, salesWeek);
            print("Michael Griffith", socialSecurity, taxRate, 0.12M, 0.2M, 14000);
        }
    }

    class Exercise_10
    {
        internal static void Run()
        {
            const double pi = 3.14159;
            double input = 0;
            try 
            {
                Console.Write("Radius: ");
                input = double.Parse(Console.ReadLine());
                Console.WriteLine("Circumference of a Circle\n\n" +
                              "Circumference: {0}", (2 * pi) * input);
            }
            catch 
            {
                Console.WriteLine("Invalid Input.");
                Exercise_10.Run();
            }   
        }
    }
}
