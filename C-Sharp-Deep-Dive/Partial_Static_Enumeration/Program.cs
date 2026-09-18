using Partial_Static_Enumeration.Enum;
using Partial_Static_Enumeration.Partial_Class;

Person person = new()
{
    Name = "Sakib",
    Age = 26
};
person.ShowName();


//Enumeration
OrderStatus status = OrderStatus.Delevered;
Console.WriteLine(status);

