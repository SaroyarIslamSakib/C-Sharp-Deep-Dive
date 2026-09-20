using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Library
{
    public interface IAggregateRoot<T>
    {
        public T Id { get; set; }
    }
}
