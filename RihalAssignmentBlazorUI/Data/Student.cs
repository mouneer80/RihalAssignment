using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssignmentBlazorUI.Data
{
    public class Student
    {
        public int Id { get; set; }
        public int Class_Id { get; set; }
        public int Country_Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
    }
}
