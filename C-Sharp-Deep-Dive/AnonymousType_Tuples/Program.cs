#region Anonymous Types
var person = new
{
    Name = "Sakib Hasan",
    Age = 25,
    Address = new
    {
        CurrentAddress = "Dhaka",
        PermanentAddress = "Panchagarh"
    }
};

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
Console.WriteLine(person.Address.CurrentAddress);
#endregion

#region Tuples
var student = new Tuple<int, string>(108, "Sakib Hasan");
Console.WriteLine(student.Item1);
Console.WriteLine(student.Item2);

//Value Tuples
(int Id, string Name) students = (214108, "Saroyar Islam");
Console.WriteLine(students.Id);
Console.WriteLine(students.Name);
#endregion