using System.ComponentModel.DataAnnotations;

namespace StudentsMVC.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
