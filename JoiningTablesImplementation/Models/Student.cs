using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JoiningTablesImplementation.Models
{
    public class Student
    {
        [Key]
        public int StdId { get; set; }
        [Required,Display(Name ="Student Name")]
        public string StdName { get; set; }
        [Required,Display(Name ="Student Number")]
        public string stdNum { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}