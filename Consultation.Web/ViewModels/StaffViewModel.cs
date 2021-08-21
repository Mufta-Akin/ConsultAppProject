﻿using Consultation.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Consultation.Web.ViewModels
{
    public class StaffViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile { get; set; }
    }

}
