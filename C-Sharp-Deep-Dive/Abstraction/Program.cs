#region Abtract Class
using Abstraction.AbstractClass;
using Abstraction.Interface;

Teacher teacher = new("Sakib", 25, 500000);
#endregion
#region Interfaces
IAnimal animal = new Dog()
{
    Colour = "Black"
};
animal.MakeSound();
Console.WriteLine(animal.GetColour());
#endregion
#region Multiple Interface
IEmployee employee = new Abstraction.Interface.Person();
ITeacher teacher1 = new Abstraction.Interface.Person();

employee.ShowEmployeeSalary();
teacher1.ShowTeacherSalary();

Console.WriteLine(employee.GetName());
Console.WriteLine(teacher1.GetName());
#endregion

#region Interface Inheritance
IBangladeshBank bank = new BangladeshBank();
bank.ShowName();
#endregion