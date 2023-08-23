using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerProject.Models
{
    public class Producer
    {
        //unique id for each teacher
        [Key]
        public int ProducerId { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        //A producer can have many movies.
        public List<Movie> Movies { get; set; }
    }
}
