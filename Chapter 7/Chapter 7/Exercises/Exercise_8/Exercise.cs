using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7.Exercises.Exercise_8
{
    class Exercise : ConsoleMenu.Exercise
    {
        private double[] homeworkScores = new double[10];

        public override void Run()
        {
            Console.WriteLine("Homework Scores\n");
            for (int i = 0; i < homeworkScores.Length; i++) 
            {
                Console.Write("Score: ");
                homeworkScores[i] = Trampoline(GetScore);
            }

            double highest = homeworkScores.Max();
            double lowest = homeworkScores.Min();
            double averageExl = (homeworkScores.Sum() - highest - lowest) / 8;

            Console.WriteLine("\n Average Excluding Highest & Lowest: {0}\n" +
                              "                            Highest: {1}\n" +
                              "                             Lowest: {2}\n",
                              averageExl, highest, lowest);
        }

        delegate double VoidFunc();
        private double GetScore()
        {
            try
            {
                double result = double.Parse(Console.ReadLine());
                if (result > -1 && result < 11)
                {
                    return result;
                }
                else 
                {
                    Console.WriteLine("Number not in range of 1-10");
                    return -1;
                } 
            }
            catch
            {
                Console.WriteLine("ERROR: Please enter a valid number 1-10.");
                return -1;
            }
        }

        private double Trampoline(VoidFunc function)
        {
            double success = -1;
            while (success == -1)
                success = function();
            return success;
        }
    }
}
