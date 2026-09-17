namespace Abstraction.AbstractClass
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; } = 0;

        //Constractor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //Abstract method
        public abstract double CalculateSalary(double bonus);


    }
}
