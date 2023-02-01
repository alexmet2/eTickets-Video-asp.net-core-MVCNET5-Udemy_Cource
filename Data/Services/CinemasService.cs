using eTickets_Video_asp.net_core_MVCNET5.Data.Base;
using eTickets_Video_asp.net_core_MVCNET5.Models;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
