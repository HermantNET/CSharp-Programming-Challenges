using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_7.Exercises.Exercise_4
{
    class Exercise : ConsoleMenu.Exercise
    {
        private double[] values1 = { 2, 9, 11, 5, 6, 13, 17, 2, 4, 7 };
        public double[] Values1 { get { return values1; } }
        private double[] values2 = { 12, 3, 7, 8, 1, 8, 4, 14, 21, 10 };
        public double[] Values2 { get { return values2; } }
        private double[] valuesSum = new double[10];
        public double[] ValuesSum { get { return valuesSum; } set { valuesSum = value; } }

        public override void Run()
        {
            for (int i = 0; i < values1.Length; i++)
            {
                valuesSum[i] = values1[i] + values2[i];
            }

            string result = "Values 1 \t| Values 2 \t| Values Sum\n" +
                            "------------------------------------\n";
            for (int i = 0; i < valuesSum.Length; i++) 
            {
                result += String.Format("{0,9}\t|{1,9}\t|{2,11}\n", values1[i], Values2[i], valuesSum[i]);
            }

                MessageBox.Show(result);
        }
    }
}
