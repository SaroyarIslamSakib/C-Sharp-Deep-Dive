using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    public class Person : IEmployee, ITeacher
    {
        public void ShowEmployeeSalary()
        {
            Console.WriteLine("Employee Salary is 20k");
        }
        public void ShowTeacherSalary()
        {
            Console.WriteLine("Teacher Salary is 50k");
        }

        string IEmployee.GetName()
        {
            return "EmpName";
        }
        string ITeacher.GetName()
        {
            return "TeacherName";
        }
    }
}
