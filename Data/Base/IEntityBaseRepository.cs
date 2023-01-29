using eTickets_Video_asp.net_core_MVCNET5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);


    }
}
