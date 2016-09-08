using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_1
{
    class Employee
    {
        #region Properties

        public int EmployeeNumber { get; set; }

        private string _name = "NA";
        public string Name { get { return _name; } set { _name = value; } }

        private DateTime _dateofHire = DateTime.Today;
        public DateTime DateOfHire { get { return _dateofHire; } set { _dateofHire = value; } }

        public decimal MonthlySalary { get; set; }

        #endregion

        #region Constructors

        public Employee() { }

        public Employee(int num, string name) { EmployeeNumber = num; Name = name; }

        public Employee(int num, string name, Decimal monthlySalary) { EmployeeNumber = num; Name = name; MonthlySalary = monthlySalary; }

        public Employee(int num, string name, DateTime dateHired, decimal monthlySalary) 
        {
            EmployeeNumber = num;
            Name = name;
            DateOfHire = dateHired;
            MonthlySalary = monthlySalary;
        }

        #endregion

        public override string ToString()
        {
            return ("\nEmployee Number: " + EmployeeNumber + 
                    "\n           Name: " + Name + 
                    "\n   Date of Hire: "  + DateOfHire.ToShortDateString() +
                    "\n Monthly Salary: " + MonthlySalary.ToString("C"));
        }
    }
}
