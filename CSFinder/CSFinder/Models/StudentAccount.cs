using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSFinder.Models
{
    public class StudentAccount
    {
        public Account account { get; set; }
        public Student student { get; set; }
        public string confirmPassword { get; set; }
    }
}
