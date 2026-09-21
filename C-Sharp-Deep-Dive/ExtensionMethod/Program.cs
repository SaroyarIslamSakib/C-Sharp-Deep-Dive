using ExtensionMethod.Library;

Student student = new()
{
    Name = "Saroyar Islam Sakib"
};

string name = student.GetDisplayName("Hello ");
Console.WriteLine(name);


string city = "Dhaka";

city.Show();