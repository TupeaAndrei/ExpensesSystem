using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSystem.DAL.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task RemoveById(int id);
    }
}
