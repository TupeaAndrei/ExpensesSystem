using ExpensesSystem.DAL.Interfaces;
using ExpensesSystem.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesSystem.DAL.Classes
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Delete(T entity)
        {
            await Task.FromResult( _context.Set<T>().Remove(entity));
        }

        public async Task<List<T>> GetAll()
        {
            return await Task.FromResult(_context.Set<T>().ToList());
        }

        public async Task<T> GetById(int id)
        {
            return await Task.FromResult(_context.Set<T>().Find(id));
        }

        public async Task Insert(T entity)
        {
            await Task.FromResult(_context.Set<T>().Add(entity));
        }

        public async Task RemoveById(int id)
        {
            var found = await _context.Set<T>().FindAsync(id);
            if (found == null)
            {
                throw new Exception();
            }
            await Delete(found);
        }

        public async Task Update(T entity)
        {
            await Task.FromResult(_context.Set<T>().Update(entity));
        }
    }
}
