using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoiningTablesImplementation.Models
{
    public class ViewModel
    {
        [Key]
        public int ViewKey { get; set; }
        [Required, Display(Name = "Student Name")]
        public string StdName { get; set; }
        [Required, Display(Name = "Student Number")]
        public string stdNum { get; set; }
        [Required, Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Required, Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required, Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
    }
}