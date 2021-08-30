using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.OData.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Dept { get; set; }
        public string BloodGroup { get; set; }

    }
}