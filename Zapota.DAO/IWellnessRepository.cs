using System;
using System.Collections.Generic;

namespace Zapota.DAO
{
    public interface IWellnessRepository<T>
    {
        List<T> GetAll();
        T Get(Guid Id);
        bool Save(T entity); 
        bool Delete(Guid Id);
    }
}