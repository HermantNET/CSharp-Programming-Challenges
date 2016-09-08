using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex10
{
    class SingleFamily : Housing
    {
        public double SquareFeet { get; set; }
        public bool Garage { get; set; }

        public SingleFamily(decimal cost = 0, string address = "unavailable", int year = 1998, double feet = 0, bool garage = false)
            : base(address, year)
        {
            SquareFeet = feet;
            Garage = garage;
            amount = cost;
        }

        private decimal amount = 0;
        public override decimal RentAmount()
        {
            // Logic
            return amount;
        }
    }
}
