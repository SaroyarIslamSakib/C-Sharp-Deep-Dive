namespace Abstraction.AbstractClass
{
    public class Teacher : Person
    {
        public double Salary { get; set; }
        public Teacher(string name, int age, double salary): base(name, age)
        {
            Salary = salary;
        }
        public override double CalculateSalary(double bonus)
        {
            return Salary + bonus;
        }

    }
}
