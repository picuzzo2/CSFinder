

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSFinder.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string SID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ID { get; set; }
        public int? Type { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string? Detail { get; set; }
        public string Status { get; set; }
    }
}
