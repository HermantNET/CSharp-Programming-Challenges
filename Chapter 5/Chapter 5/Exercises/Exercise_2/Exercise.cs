using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Exercises.Exercise_2
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Console.WriteLine("Number to Month\n");
            Input();
        }

        private void Input()
        {
            Console.Write("Number: ");
            switch(int.Parse(Console.ReadLine()))
            {
                case 28:
                    Console.WriteLine("February");
                    Console.WriteLine("Days in February: '{0}'", DateTime.DaysInMonth(DateTime.Now.Year, 2));
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}
