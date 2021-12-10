using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RihalAssignment.Models
{
    [Table("classes")]
    public class Class
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("class_name")]
        [Required]
        public string Name { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("modified_date")]
        public DateTime ModifiedDate { get; set; }
        // Navigation properties
        //[JsonIgnore]
        //public List<Student> Students { get; set; }
    }
}
