#region Method Syntax
using LINQ.Data;

var passingStudent = Student.GetStudents().Where(x => x.Marks >= 60);
//foreach(var s in passingStudent)
//{
//    Console.WriteLine(s.Name);
//}

var students = Student.GetStudents();

var passingCSEStudent = students.Where(x => x.Marks >= 90).OrderBy(x => x.Id);
//foreach (var s in passingCSEStudent)
//{
//   Console.WriteLine($"Id:{s.Id} Name: {s.Name}");
//}

#endregion

#region Query Syntax
var passingStar = (from student in students
                   where student.Marks > 80
                   && student.Department == "CSE"
                   select new
                   {
                       student.Name,
                       student.Department,
                       student.Marks
                   }).ToList();
foreach(var student in passingStar)
{
    Console.WriteLine(student.Name);
}


//More then avg mark student
var GreaterAvg = (from student in students
                 where student.Marks > ((from s in students
                                         select s.Marks).Average())
                 select student).ToList();
foreach (var student in GreaterAvg)
{
    Console.WriteLine(student.Marks);
}
#endregion

DateTime dateTime = new DateTime(2026, 6, 5);