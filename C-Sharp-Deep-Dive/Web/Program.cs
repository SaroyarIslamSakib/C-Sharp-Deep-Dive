#region Encapsulation
using Inheritence.MethodHiding;
using Methods.Encapsulation;
using Methods.ParameterModifier;

Person person = new Person();
person.SetName("John Doe");
person.SetEmail("sisakib232@gmail.com");
person.SetPhone("123-456-7890");
Console.WriteLine("------------Encapsulation Example------------");
Console.WriteLine(person.GetName());
Console.WriteLine(person.GetEmail());
Console.WriteLine(person.GetPhone());
#endregion

#region Parameter Modifier
Employee employee = new Employee("John Doe", 50000);
int bonus = 50;
int totalSalary = employee.CalculateSalary(ref bonus);
Console.WriteLine("------------Parameter Modifier Example------------");
Console.WriteLine($"Bonus: {bonus}");
Console.WriteLine($"Total Salary: {totalSalary}");

int bonus2;
int totalSalary2 = employee.CalculateSalary2(out bonus2);
Console.WriteLine($"Bonus2: {bonus2}");
Console.WriteLine($"Total Salary: {totalSalary2}");

int bonus3 = 150;
int totalSalary3 = employee.CalculateSalary3(in bonus3);
Console.WriteLine($"Total Salary: {totalSalary3}");

employee.DisplaySkills("C#", "Java", "Python");
#endregion

#region Method Hiding
Animal animal = new Animal();
animal.Speak(); // Output: Animal speaks
Dog dog = new Dog();
dog.Speak(); // Output: Dog barks 

Animal animalDog = new Dog();
animalDog.Speak();
#endregion