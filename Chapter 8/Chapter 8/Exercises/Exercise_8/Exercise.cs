using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8.Exercises.Exercise_8
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Random rand = new Random();
            int[,] randNumbers = new int[5, 4];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 4; j++)
                    randNumbers[i, j] = rand.Next(0, 101);

            int smallestNum = randNumbers[0, 0],
                index1 = 0,
                index2 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (randNumbers[i, j] < smallestNum)
                    {
                        smallestNum = randNumbers[i, j];
                        index1 = i;
                        index2 = j;
                    }

                    Console.Write(randNumbers[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nSmallest Value = {0}\n Indexes = {1},{2}", smallestNum, index2, index1);
        }
    }
}
