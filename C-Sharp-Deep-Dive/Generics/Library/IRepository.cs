using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Library
{
    public interface IRepository<Tkey,TEntity> where Tkey : struct
                                           where TEntity : class
    {
        void Show();
    }
}
