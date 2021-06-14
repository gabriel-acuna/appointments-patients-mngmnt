using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appointments_patients.Repositories.Interfaces
{
   interface IUpdate <T> where T:class {

        Task UpdateAsync(T t);
        Task UpdateAsync(IEnumerable<T> t);
       
   }
}