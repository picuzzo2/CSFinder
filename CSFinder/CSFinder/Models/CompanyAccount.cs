using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSFinder.Models
{
    public class CompanyAccount
    {
        public Account account { get; set; }
        public Company company { get; set; }
        public string comfirmPassword { get; set; }
    }
}
