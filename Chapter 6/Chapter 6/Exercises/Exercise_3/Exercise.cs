using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.Exercises.Exercise_3
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Console.WriteLine("Grade Average Calculator\nInput grades, when finished type 'done'.");
            string input = "0";
            double sum = 0;
            int count = -1;
            while (input != "done")
            {
                try
                {
                    double grade = double.Parse(input);
                    if (grade > 100 || grade < 0) throw new System.ArgumentOutOfRangeException(null, "Grade out of range. Please enter a grade between 0 and 100.");
                    sum += grade;
                    count++;
                }
                catch (System.Exception e)
                {
                    if (e is System.ArgumentOutOfRangeException)
                    {
                        Console.WriteLine(e.Message);
                    }
                    else 
                    {
                        Console.WriteLine("ERROR: Please enter a valid number.");
                    }
                }
                Console.Write("\nType 'done' to calculate average.\nGrade: \t");
                input = Console.ReadLine();
            }
            Console.WriteLine("\nAverage: {0:##.#}\nLetter Grade: {1}", sum / count, Mallem.Convert.Grade.ToLetterGrade(sum / count));
        }
    }
}
