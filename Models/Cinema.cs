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
  public int CinemaId { get; set; }

  public string Logo { get; set; }

  public string Name { get; set; }

  public string Bio { get; set; }
 }
}