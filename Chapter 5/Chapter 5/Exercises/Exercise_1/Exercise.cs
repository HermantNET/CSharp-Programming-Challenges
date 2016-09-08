using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Exercises.Exercise_1
{
    class Exercise : ConsoleMenu.Exercise
    {
        public double val1 { get; set; }
        public double val2 { get; set; }

        private void Input() 
        {
            Console.Write("Value 1: ");
            val1 = double.Parse(Console.ReadLine());
            Console.Write("Value 2: ");
            val2 = double.Parse(Console.ReadLine());
        }

        private void CompareValues()
        {
            if (val1 == val2)
            {
                Console.WriteLine("Value 1: '{0}', is equal to Value 2: '{0}'", val1);
            }
            else if (val1 > val2)
            {
                Console.WriteLine(val2);
            }
            else
            {
                Console.WriteLine(val1);
            }
        }

        public override void Run()
        {
            Console.WriteLine("The Smallest Value\n");

            Input();
            CompareValues();
        }
    }
}
