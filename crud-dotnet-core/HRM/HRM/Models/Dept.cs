using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Dept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Display(Name = "Dept. Name")]
        [StringLength(150)]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
