using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Validations;

namespace api.Dtos.User
{
    public class UserEditDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty; 
        [Required]
        [MaxLength(1000, ErrorMessage = " The field FullName must be a string or array type with a maximum length of '1000'.")]
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [PhoneNumber]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}