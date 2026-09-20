using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Library
{
    public class Student : IAggregateRoot<int>
    {
        public int Id { get; set; }

        public Student()
        {
            Id = 0;
        }
    }
}
