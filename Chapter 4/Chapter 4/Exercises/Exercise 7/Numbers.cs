using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_7
{
    class Numbers
    {
        public int val1 { get; set; }
        public int val2 { get; set; }


        public Numbers(int one, int two) 
        {
            val1 = one;
            val2 = two;
        }


        public double Sum()
        {
            return val1 + val2;
        }

        public double Product()
        {
            return val1 * val2;
        }

        public double Average()
        {
            return (val1 + val2) / 2;
        }

        public double SquaredAvg()
        {
            double[] results = { Math.Pow(val1, val2), Math.Pow(val2, val1) };
            return (results[0] + results[1]) / 2;
        }
    }
}
