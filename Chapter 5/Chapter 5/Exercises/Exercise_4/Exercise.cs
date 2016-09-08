using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_5.Exercises.Exercise_4
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Input();
        }

        private void Input()
        {
            dynamic employee;
            string input = string.Empty;

            Console.Write("Employee Type: ");
            input = Console.ReadLine().ToLower();
            if (Regex.IsMatch(input, @"^(salary|salaried)"))
            {
                Console.Write("Salary: ");
                employee = new Salaried(double.Parse(Console.ReadLine()));
                Console.WriteLine(employee.Total.ToString("c"));
            }
            else if (input == "hourly")
            {
                double rate = 0, hours = 0;

                Console.Write("Hourly Rate: ");
                rate = double.Parse(Console.ReadLine());
                Console.Write("Hours Worked: ");
                hours = double.Parse(Console.ReadLine());
                employee = new Hourly(rate, hours);
                Console.WriteLine(employee.Total.ToString("c"));
            }
        }
    }
}
