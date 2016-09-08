using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Exercises.Exercise_3
{
    class Exercise : ConsoleMenu.Exercise
    {
        private double[] grades = new double[5];

        public override void Run()
        {
            Input();
            Grade();
        }

        private void Grade()
        {
            double total = 0;
            foreach (double grade in grades) 
            {
                total += grade;
            }
            total = (total == 0) ? 0 : total / grades.Length;

            Console.Write("Grade: ");
            if (total >= 90)
            {
                Console.WriteLine("'A'");
            }
            else if (total >= 80) 
            {
                Console.WriteLine("'B'");
            }
            else if (total >= 70)
            {
                Console.WriteLine("'C'");
            }
            else if (total >= 60)
            {
                Console.WriteLine("'D'");
            }
            else
            {
                Console.WriteLine("'F'");
            }
        }

        private void Input()
        {
            for ( int i = 0; i < grades.Length; i++ )
            {
                Console.Write("Enter Grade: ");
                grades[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
