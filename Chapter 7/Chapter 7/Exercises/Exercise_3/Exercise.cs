using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7.Exercises.Exercise_3
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Weather week = new Weather(new double[] { 72, 68.5, 65.7, 76.2, 75.2, 70.1, 68 });
            Console.WriteLine("        Highest Temperature: \t{0:#.##}", week.HighestTemp());
            Console.WriteLine("         Lowest Temperature: \t{0:#.##}", week.LowestTemp());
            Console.WriteLine("        Average Temperature: \t{0:#.##}", week.AverageTemp());
            Console.WriteLine("Avg. Temp. excluding lowest: \t{0:#.##}", week.AverageTempExlLowest());
            Console.WriteLine("              Days below 71: \t{0:#.##}", week.DaysBelow(71));
        }
    }
}
