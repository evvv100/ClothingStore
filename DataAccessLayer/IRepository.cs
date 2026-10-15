using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Core;

namespace DataAccessLayer
{
    public interface IRepository<T> where T : IDomainObject
    {
        void Add(T item);
        void Delete(int id); 
        List<T> ReadAll(); 
        T ReadById(int id); 
        void Update(T item); 
    }
}
