using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListifyWebApp.DataAccess
{
    public interface IRepository
    {
        public interface IRepository<T>
        {
            Task<T> GetByIdAsync(string id);
            Task<IEnumerable<T>> GetAllAsync();
            Task AddAsync(T entity);
            Task UpdateAsync(string id, T entity);
            Task DeleteAsync(string id);
        }
    }
}
