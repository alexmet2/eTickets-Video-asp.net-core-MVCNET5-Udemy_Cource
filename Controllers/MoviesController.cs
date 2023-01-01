using eTickets_Video_asp.net_core_MVCNET5.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets_Video_asp.net_core_MVCNET5.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context= context;  
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = _context.Movies.ToListAsync();
            return View();
        }

    }
}
