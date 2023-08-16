using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// This is the model for the Teacher class
namespace SchoolManagerProject.Models
{
    public class Teacher
    {
        //unique id for each teacher
        [Key]
        public int TeacherId { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}