using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8.Exercises.Exercise_10
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Int64[,] enrolled = { {1091150, 18, 20},
                                  {1091250, 11, 20},
                                  {1091270, 9, 25},
                                  {1091300, 4, 20},
                                  {1091350, 20, 20} };

            for(int i = 0; i <= enrolled.GetUpperBound(0); i++) 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Course " + enrolled[i,0]);
                Console.ResetColor();
                Console.WriteLine("Seats available = {0}\n" +
                                  "---------------------",
                                  enrolled[i,2] - enrolled[i,1]);
            }
        }
    }
}
