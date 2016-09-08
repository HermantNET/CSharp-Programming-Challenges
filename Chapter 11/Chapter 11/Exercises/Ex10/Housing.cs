using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex10
{
    class Housing
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public virtual decimal RentAmount() 
        {
            return 0;
        }

        public Housing(string address = "unavailable", int year = 1998) 
        {
            Address = address;
            YearBuilt = year;
        }
    }
}
