using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerProject.Models
{
    public class Cinema
    {
        //unique id for each teacher
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        //A Cinema can have many movies.
        public List<Movie> Movies { get; set; }
    }
}
