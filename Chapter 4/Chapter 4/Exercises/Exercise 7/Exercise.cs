using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_7
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Random rand = new Random();
            var num = new Numbers(rand.Next(2, 10), rand.Next(2, 10));
            Console.WriteLine("Values: {0}, {1}", num.val1, num.val2);
            Console.WriteLine("Sum: {0}, Product: {1}, Average: {2}, Squared Average: {3}", num.Sum(), num.Product(), num.Average(), num.SquaredAvg());
        }
    }
}
