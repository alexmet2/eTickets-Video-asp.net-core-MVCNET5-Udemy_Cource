using eTickets_Video_asp.net_core_MVCNET5.Data.Base;
using eTickets_Video_asp.net_core_MVCNET5.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}
