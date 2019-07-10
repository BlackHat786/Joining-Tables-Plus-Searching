using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoiningTablesImplementation.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required,Display(Name ="Course Name")]
        public string CourseName { get; set; }
        [Required,Display(Name ="Number Of Modules")]
        public int NumModules { get; set; }
        [Required,Display(Name ="Start Date")]
        public DateTime StartDate { get; set; }
        [Required,Display(Name ="End Date")]
        public DateTime EndDate { get; set; }
    }
}