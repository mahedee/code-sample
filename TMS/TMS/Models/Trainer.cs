using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Trainer
    {

        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }
        public string Oranizaton { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public bool IsActive { get; set; }
    }
}