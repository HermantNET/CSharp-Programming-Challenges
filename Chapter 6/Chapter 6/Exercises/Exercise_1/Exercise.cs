using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.Exercises.Exercise_1
{
    class Exercise : ConsoleMenu.Exercise
    {
        private int highestNum = 0;
        private int lowestNum = 0;
        private int evenNumbers = 0;
        private int range = 0;

        Random rand = new Random();

        public override void Run()
        {
            Console.WriteLine("1000 Random Numbers\n");
            Generate();
            range = highestNum - lowestNum;
            Print();
        }

        public Exercise()
        {
            int num = rand.Next(0, 1001);
            lowestNum = num;
            highestNum = num;
            if (num / 2 == 0)
                evenNumbers++;
        }

        private void Print()
        {
            Console.WriteLine("Even Numbers: " + evenNumbers +
                            "\nLowest Number: " + lowestNum +
                            "\nHighest Number: " + highestNum +
                            "\nNumber Range: " + range);
        }

        private void Generate()
        {
            for (var i = 0; i < 100; i++)
            {
                int num = rand.Next(0, 1001);
                if (num % 2 == 0)
                    evenNumbers++;
                if (lowestNum > num)
                    lowestNum = num;
                if (highestNum < num)
                    highestNum = num;
            }
        }
    }
}
