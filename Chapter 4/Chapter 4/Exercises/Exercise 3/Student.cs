using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_3
{
    class Student
    {
        #region properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }
        public string Classification { get; set; }
        public string Major { get; set; }
        
        #endregion

        public Student() { }
        public Student(string first, string last, double gpa, string classification, string major) 
        {
            FirstName = first;
            LastName = last;
            GPA = gpa;
            Classification = classification;
            Major = major;
        }
        public override string ToString()
        {
            return "\n    FIRST NAME: " + FirstName +
                   "\n     LAST NAME: " + LastName +
                   "\n           GPA: " + GPA +
                   "\nCLASSIFICATION: " + Classification +
                   "\n         MAJOR: " + Major;
        }
    }
}
