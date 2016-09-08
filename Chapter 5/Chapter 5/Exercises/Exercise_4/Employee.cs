using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Exercises.Exercise_4
{
    abstract class Employee
    {
        private const double FED_TAX = .18D;
        private const double RETIREMENT_CONTR = .1D;
        private const double SOC_SECURITY = .6D;

        protected double SubTotal { get; set; }

        protected double _total = 0;
        public double Total { get { return _total; } }

        internal void CalcTotal() 
        {
            _total = SubTotal * (FED_TAX + RETIREMENT_CONTR + SOC_SECURITY);
        }
    }

    class Hourly : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public Hourly(double rate, double hours) 
            {
                HourlyRate = rate;
                HoursWorked = hours;
                Calculate();
                CalcTotal();
            }

        private void Calculate()
        {
            int overtime = 40;
            double overtimeRate = 1.5;

            if (HoursWorked - overtime >= 0)
            {
                SubTotal = overtime * HourlyRate;
                SubTotal += (((HoursWorked - overtime) * HourlyRate) * overtimeRate);
            }
            else
            {
                SubTotal = HoursWorked * HourlyRate;
            }
        }
    }

    class Salaried : Employee
    {
        public double Salary { get; set; }

        public Salaried(double salary)
        {
            Salary = salary;
            SubTotal = Salary;
            CalcTotal();
        }
    }
}
