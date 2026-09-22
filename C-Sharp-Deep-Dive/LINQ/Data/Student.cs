using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }
        public bool IsActive { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Sakib",
                    Department = "CSE",
                    City = "Dhaka",
                    Age = 23,
                    Marks = 85,
                    IsActive = true
                },

                new Student
                {
                    Id = 2,
                    Name = "Rahim",
                    Department = "EEE",
                    City = "Gazipur",
                    Age = 22,
                    Marks = 72,
                    IsActive = true
                },

                new Student
                {
                    Id = 3,
                    Name = "Karim",
                    Department = "CSE",
                    City = "Dhaka",
                    Age = 24,
                    Marks = 91,
                    IsActive = true
                },

                new Student
                {
                    Id = 4,
                    Name = "Nusrat",
                    Department = "BBA",
                    City = "Chittagong",
                    Age = 21,
                    Marks = 68,
                    IsActive = true
                },

                new Student
                {
                    Id = 5,
                    Name = "Tania",
                    Department = "CSE",
                    City = "Gazipur",
                    Age = 22,
                    Marks = 88,
                    IsActive = false
                },

                new Student
                {
                    Id = 6,
                    Name = "Hasan",
                    Department = "EEE",
                    City = "Dhaka",
                    Age = 25,
                    Marks = 76,
                    IsActive = true
                },

                new Student
                {
                    Id = 7,
                    Name = "Rafi",
                    Department = "CSE",
                    City = "Rajshahi",
                    Age = 23,
                    Marks = 95,
                    IsActive = true
                },

                new Student
                {
                    Id = 8,
                    Name = "Mim",
                    Department = "BBA",
                    City = "Dhaka",
                    Age = 20,
                    Marks = 81,
                    IsActive = true
                },

                new Student
                {
                    Id = 9,
                    Name = "Arif",
                    Department = "EEE",
                    City = "Gazipur",
                    Age = 24,
                    Marks = 64,
                    IsActive = false
                },

                new Student
                {
                    Id = 10,
                    Name = "Jannat",
                    Department = "CSE",
                    City = "Chittagong",
                    Age = 22,
                    Marks = 89,
                    IsActive = true
                },

                new Student
                {
                    Id = 11,
                    Name = "Fahim",
                    Department = "BBA",
                    City = "Dhaka",
                    Age = 23,
                    Marks = 73,
                    IsActive = true
                },

                new Student
                {
                    Id = 12,
                    Name = "Nayeem",
                    Department = "CSE",
                    City = "Gazipur",
                    Age = 25,
                    Marks = 92,
                    IsActive = true
                }
            };
            return students;
        }
    }
}
