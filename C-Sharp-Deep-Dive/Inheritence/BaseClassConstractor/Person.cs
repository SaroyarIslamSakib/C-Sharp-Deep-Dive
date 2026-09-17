using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence.BaseClassConstractor
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
