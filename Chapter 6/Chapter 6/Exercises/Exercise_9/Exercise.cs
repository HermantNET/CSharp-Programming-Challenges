using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.Exercises.Exercise_9
{
    class Exercise : ConsoleMenu.Exercise
    {
        private int population = 23962;
        public int Population { get { return population; } set { population = value; } }

        private double growthRate = .04;
        public double GrowthRate { get { return growthRate; } set { growthRate = value; } }

        public override void Run()
        {
            int[] growth = CalculateGrowth(5);
            Print(growth);
        }

        private void Print(int[] growth)
        {
            for (int i = 0; i < growth.Length; i++)
                Console.WriteLine("| Year {0,-19}|\n" +
                                  "|-------------------------|\n" +
                                  "| Population: {1,-12:N0}|\n" +
                                  "|-------------------------|\n",
                                  i + 1, growth[i]);
        }

        public int[] CalculateGrowth(int numYears)
        {
            int[] years = new int[numYears];
            int popCount = population;
            for (int i = 0; i < numYears; i++) 
            {
                int projectedInc = (int)Math.Ceiling(popCount * growthRate);
                years[i] = popCount + projectedInc;
                popCount += projectedInc;
            }
            return years;
        }
    }
}
