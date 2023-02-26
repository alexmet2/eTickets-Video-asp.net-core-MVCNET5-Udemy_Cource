using eTickets_Video_asp.net_core_MVCNET5.Models;
using System.Collections.Generic;

namespace eTickets_Video_asp.net_core_MVCNET5.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {

        public NewMovieDropdownsVM()
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }

        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }


    }
}
