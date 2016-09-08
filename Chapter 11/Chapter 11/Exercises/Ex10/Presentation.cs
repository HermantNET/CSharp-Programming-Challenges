using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex10
{
    static class Presentation
    {
        static MultiUnit multi = new MultiUnit(1200, "421 Yarn Drive", 2002, 10);
        static SingleFamily single = new SingleFamily(2200, "9392 Tree Trail", 1996, 1250, true);

        static public string MultiUnit()
        {
            return string.Format(
                "Address: {0}\n" +
                "Year Built: {1}\n" +
                "Units Available: {2}\n" +
                "Price: {3:C}\n",
                multi.Address, multi.YearBuilt, multi.NumberOfUnits(), multi.RentAmount()
                );
        }

        static public string SingleFamily()
        {
            return string.Format(
                "Address: {0}\n" +
                "Year Built: {1}\n" +
                "Square Feet: {2:N}\n" +
                "Garage: {3}\n" +
                "Price: {4:C}\n",
                single.Address, single.YearBuilt, single.SquareFeet, single.Garage, single.RentAmount()
                );
        }
    }
}
