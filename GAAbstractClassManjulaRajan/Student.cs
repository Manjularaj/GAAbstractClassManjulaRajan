using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAAbstractClassManjulaRajan
{
    public class Student :Person
    {
        public Student(string name, int id, double gpa) : base(name, id)
        {
            GPA = gpa;
        }

        public double GPA { get; set; }

        public override string GetDetails()
        {
            return $"{Name}, ID: {ID}, GPA: {GPA}";
        }
    }

    
}
