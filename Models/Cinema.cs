using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerProject.Data.Base;

namespace SchoolManagerProject.Models
{
    public class Cinema : IEntityBase
    {
        //unique id for each teacher
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Logo is required.")]
        public string Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Cinema Name is required.")]
        [StringLength(
            50,
            MinimumLength = 2,
            ErrorMessage = "Cinema Name must be between 2 and 50 characters."
        )]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required.")]
        [StringLength(
            500,
            MinimumLength = 10,
            ErrorMessage = "Bio must be between 10 and 500 characters."
        )]
        public string Bio { get; set; }

        //Relationships
        //A Cinema can have many movies.
        public List<Movie> Movies { get; set; }
    }
}
