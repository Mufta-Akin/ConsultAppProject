using System;
using System.ComponentModel.DataAnnotations;

namespace Consultation.Web.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Range(0, 130)]
        public int Age { get; set; }

    }

}
