using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appointments_patients.Repositories.Interfaces
{
    interface IRead<T, Id> where T : class
    {
       
    Task<IEnumerable<T>> ReadAllAsync();

    Task<T> ReadOneAsync(Object Id);
   }
}