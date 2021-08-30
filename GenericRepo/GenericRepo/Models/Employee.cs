using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Designation { get; set; }
        public string Dept { get; set; }
    }
}