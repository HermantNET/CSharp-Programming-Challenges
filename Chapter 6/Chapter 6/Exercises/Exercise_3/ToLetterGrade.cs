using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mallem.Convert
{
    class Grade
    {
        public static char ToLetterGrade(double total)
        {
            Console.Write("Grade: ");
            if (total >= 90)
            {
                return 'A';
            }
            else if (total >= 80)
            {
                return 'B';
            }
            else if (total >= 70)
            {
                return 'C';
            }
            else if (total >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}
