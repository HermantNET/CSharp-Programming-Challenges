using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMenu;

namespace Chapter_3.Exercises
{
    class Exercise_3 : Exercise
    {
        internal void Print(double[] values)
        {
            Console.WriteLine("------------------------------------\n" +
                              "  Area           |  Perimeter\n" +
                              "------------------------------------\n" +
                              "{0,16} | {1,16}", values[0], values[1]);
        }

        public override void Run()
        {
            Console.WriteLine("Area and Perimeter Calculator\n");
            Print(Calc(Values()));
        }

        // Instructions state to get values via methods
        private double[] Values()
        {
            double[] values = { 0, 0 };

            Console.Write("Enter 'X': ");
            double.TryParse(Console.ReadLine(), out values[0]);

            Console.Write("Enter 'Y': ");
            double.TryParse(Console.ReadLine(), out values[1]);

            return values;
        }

        private double[] Calc(double[] values) 
        {
            double[] result = {Area(values), Perimeter(values)};
            return result;
        }

        private double Area(double[] values) 
        {
            return values[0] * values[1];
        }

        private double Perimeter(double[] values)
        {
            return (values[0] + values[1]) * 2;
        }
    }
}
