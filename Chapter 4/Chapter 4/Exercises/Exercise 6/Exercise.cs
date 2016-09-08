using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_6
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Random rand = new Random();
            double num = 0;

            var mun = new Money(rand.NextDouble() * 10);
            Console.WriteLine(mun.ToString());
            Console.WriteLine(mun.ToCoinAmount());

            num = rand.NextDouble() * 10;
            mun.IncrementMoney(num);
            Console.WriteLine("Incremented by {0:C}: " + mun.ToString(), num);

            num = rand.NextDouble() * 10;
            mun.DecrementMoney(num);
            Console.WriteLine("Decremented by {0:C}: " + mun.ToString(), num);
        }
    }
}
