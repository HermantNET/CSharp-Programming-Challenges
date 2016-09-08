using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_3
{
    class Exercises
    {
        internal static void ExerciseHandler(int currentSelection)
        {
            Exercise exercise;
            switch (currentSelection) 
            {
                case 0:
                    exercise = new Exercise_1();
                    exercise.Run();
                    break;
            }
        }
    }

    abstract class Exercise 
    {
        internal abstract void Print();
        public abstract void Run();
    }

    class Exercise_1 : Exercise
    {
        internal override void Print()
        {
            Console.WriteLine("ayy lamo");
        }

        public override void Run()
        {
            Print();
        }
    }
}
