using eTickets_Video_asp.net_core_MVCNET5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task <Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }
}
