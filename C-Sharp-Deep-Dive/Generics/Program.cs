using Generics.Library;

Repository<Student> repository = new();

Student student = repository.Create();

Console.WriteLine(student.Id);