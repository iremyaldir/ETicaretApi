using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Application.Repositories
{
    public interface IWriteRepository<T> where T: class, new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
    }
}
