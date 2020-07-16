using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Web.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherId { get; set; }
        public string FullName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
    }
}
