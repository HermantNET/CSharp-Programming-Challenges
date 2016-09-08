using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_5
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            var trip = new Trip(26, 2, 1);
            Console.WriteLine(trip.ToString());

            var trip2 = new Trip(52, 4, 2);
            Console.WriteLine(trip.ToString());
        }
    }
}
