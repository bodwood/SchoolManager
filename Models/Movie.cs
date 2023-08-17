using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerProject.Data;

namespace SchoolManagerProject.Models
{
 public class Movie
 {
  //unique id for each teacher
  [Key]
  public int MovieId { get; set; }

  public string Name { get; set; }

  public string Description { get; set; }

  public double Price { get; set; }

  public string ImageURL { get; set; }

  public DateTime StartDate { get; set; }

  public DateTime EndDate { get; set; }

  public MovieCategory MovieCategory { get; set; }
 }
}