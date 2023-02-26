using eTickets_Video_asp.net_core_MVCNET5.Data.Base;
using eTickets_Video_asp.net_core_MVCNET5.Data.ViewModels;
using eTickets_Video_asp.net_core_MVCNET5.Models;
using System.Threading.Tasks;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {

        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownValues();
        Task AddNewMovieAsync(NewMovie data);
        Task UpdateMovieAsync(NewMovie data);
    }
}
