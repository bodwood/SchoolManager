using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagerProject.Models
{
    public class Actor
    {
        //unique id for each teacher
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required.")]
        public string ProfilePicture { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(
            50,
            MinimumLength = 2,
            ErrorMessage = "First Name must be between 2 and 50 characters."
        )]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(
            50,
            MinimumLength = 2,
            ErrorMessage = "Last Name must be between 2 and 50 characters."
        )]
        public string LastName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required.")]
        [StringLength(
            500,
            MinimumLength = 10,
            ErrorMessage = "Bio must be between 10 and 500 characters."
        )]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
