using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex10
{
    class MultiUnit : Housing, IUnits
    {
        private int numberOfUnits = 0;
        public int NumberOfUnits()
        {
            return numberOfUnits;
        }

        public MultiUnit(decimal cost, string address, int year, int units)
            : base(address, year) 
        {
            amount = cost;
            numberOfUnits = units;
        }

        private decimal amount = 0;
        public override decimal RentAmount()
        {
            // Logic
            return amount;
        }
    }
}
