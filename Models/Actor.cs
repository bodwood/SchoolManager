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
  
  public string ProfilePicture { get; set; }

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public string Bio { get; set; }
 }
}