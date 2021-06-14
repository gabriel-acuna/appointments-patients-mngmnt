using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appointments_patients.Repositories.Interfaces
{
    public interface ICreate<T> where T : class
    {

        Task AddAsync(T t);
        Task AddAsync(IEnumerable<T> t);
       
   }
}