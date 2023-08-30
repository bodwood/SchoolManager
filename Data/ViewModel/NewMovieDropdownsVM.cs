using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerProject.Data.Base;
using SchoolManagerProject.Models;

namespace SchoolManagerProject.Data.ViewModels
{
 public class NewMovieDropdownsVM
 {

  //constructor to initialize the lists.
  public NewMovieDropdownsVM()
  {
   Producers = new List<Producer>();
   Cinemas = new List<Cinema>();
   Actors = new List<Actor>();
  }

  public List<Producer> Producers { get; set; }

  public List<Cinema> Cinemas { get; set; }

  public List<Actor> Actors { get; set;
 }
 }
}