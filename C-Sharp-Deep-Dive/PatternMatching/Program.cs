using PatternMatching.Library;

Animal animal = new Dog();
if (animal is Dog dog)
{
    dog.MakeSound();
}

//Another Example of Pattern matching
object obj = "Sakib";
if(obj is String name)
{
    Console.WriteLine(name);
}

// Var & Dynamic

dynamic data = "Sakib";
data = 10;
data = true;

Console.WriteLine(data);

//Inner Class Example

InnerChild child = new();
child.Test();

Console.WriteLine(child?.outer.Data ?? "Not Found"); 