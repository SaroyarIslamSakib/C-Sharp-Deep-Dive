using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.ParameterModifier
{
    public class Employee
    {
        private readonly string _name;
        private readonly int _salary;

        public Employee(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }

        public int CalculateSalary(ref int bonus)
        {
            bonus = 100;
            return _salary + bonus;
        }
        public int CalculateSalary2(out int bonus)
        {
            bonus = 100;
            return _salary + bonus;
        }

        public int CalculateSalary3(in int bonus)
        {
            //bonus = 100; // This line will cause a compile-time error because 'bonus' is read-only
            return _salary + bonus;
        }

        public void DisplaySkills(params string[] skills)
        {
            Console.WriteLine("Skills:");
            foreach (var skill in skills)
            {
                Console.Write($"{skill}, ");
            }
            Console.WriteLine();
        }
    }
}
