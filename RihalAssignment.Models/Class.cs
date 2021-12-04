using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignment.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public List<Student> Students { get; set; }
    }
}
