using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerProject.Data;
using SchoolManagerProject.Data.Base;

namespace SchoolManagerProject.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }

        [Display(Name = "Movie Poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required.")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required.")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a  Category")]
        [Required(ErrorMessage = "Category is required.")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select Actors")]
        [Required(ErrorMessage = "Actor(s) is required.")]
        public List<int> ActorIds { get; set; }

        //Cinema
        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = "Cinema is required.")]
        public int CinemaId { get; set; }

        //Producer
        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Producer is required.")]
        public int ProducerId { get; set; }
    }
}
