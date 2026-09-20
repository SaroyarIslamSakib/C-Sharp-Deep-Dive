using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Library
{
    public class Repository<TEntity> where TEntity : class, IAggregateRoot<int>, new()
    {
        public TEntity Create() 
        {
            return new TEntity();
        }
    }
}
