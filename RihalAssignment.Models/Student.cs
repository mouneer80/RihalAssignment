using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public int CountryId { get; set; }
        public Country Countries { get; set; }
        public int ClassId { get; set; }
        public Class Classes { get; set; }
    }
}
