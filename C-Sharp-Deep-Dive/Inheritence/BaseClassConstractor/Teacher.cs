using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.BaseClassConstractor
{
    public class Teacher : Person
    {
        public double Salary { get; set; }
        public Teacher(int id, string name, double salary) : base(id, name)
        {
            Salary = salary;
        }
    }
}
