﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSFinder.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public string CID { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Detail { get; set; }
        public int TrainneeNeed { get; set; }
        public int CoopNeed { get; set; }
    }
}
