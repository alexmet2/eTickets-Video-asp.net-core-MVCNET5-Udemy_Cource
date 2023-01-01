using eTickets_Video_asp.net_core_MVCNET5.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTickets_Video_asp.net_core_MVCNET5.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context= context;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
