using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets_Video_asp.net_core_MVCNET5.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
