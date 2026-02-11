using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace HMSlite.Models
{
    public class Patient
    {
        [Key]
        [Display(Name = "Patient ID")]
        public int patientId { get; set; }

        [Required]
        [Display(Name = "Patient Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Blood Group")]
        public string bloodGroup { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime regDate { get; set; }


    }
}
