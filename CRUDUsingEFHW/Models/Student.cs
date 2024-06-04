using System.ComponentModel.DataAnnotations;  //provides attributes and classes to define validation rules and constraints for data models.
using System.ComponentModel.DataAnnotations.Schema;  //which provides attributes and classes for specifying database-related information, such as table names and column names.

namespace CRUDUsingEFHW.Models
{
    [Table("Student")]
    public class Student
    {
        [Key] 
        public int Id { set; get; }
        [Required]

        public string? Name { set; get; }
        [Required]

        public int Percentage { set; get; }
        [Required]
        public string? City { set;get; }
    }
}
