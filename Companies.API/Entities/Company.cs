﻿using System.ComponentModel.DataAnnotations;

namespace Companies.API.Entities
{
    public class Company
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length is 60 characters.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Company address is a required field.")]
        [MaxLength(60,ErrorMessage ="Maximum length is 60 characters.")]
        public string?  Address { get; set; }

        public string? Country { get; set; }

        //Navigation property
        public ICollection<Employee>? Employees { get; set; }
    }
}
