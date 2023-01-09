using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets_Video_asp.net_core_MVCNET5.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name= "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
