using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appointments_patients.Repositories.Interfaces
{
   interface IRemove <T> where T:class {

        Task RemoveAsync(T t);
        Task RemoveAsync(IEnumerable<T> t);
       
   }
}