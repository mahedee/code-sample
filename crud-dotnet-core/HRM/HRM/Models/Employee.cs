using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(200)]
        public string FullName { get; set; }

        [Display(Name = "Father's Name")]
        [StringLength(200)]
        public string FathersName { get; set; }

        [Display(Name = "Mother's Name")]
        [StringLength(200)]
        public String MothersName { get; set; }

        [Display(Name = "Dept")]
        public int DeptId { get; set; }

        [StringLength(250)]
        public string Designation { get; set; }

        [ForeignKey("DeptId")]
        public virtual Dept Dept { get; set; }
    }
}
