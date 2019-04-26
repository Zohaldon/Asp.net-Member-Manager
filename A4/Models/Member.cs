using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace A4.Models
{
    public class Member
    {

        [Key]
        public int MemberId { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This Field is necessary.")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        public string City { get; set; }

        [Required]
        [DataType(DataType.Text, ErrorMessage = "Please Check your input, No Numbers or Special Charaters.")]
        public string Province { get; set; }

        [Required]
        [RegularExpression("(?i)^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$",
            ErrorMessage = "Please Enter the valid Canadian Postal Code With No Space, Format: A0A0A0")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [Range(18, 120)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)] //Default Type for the password
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)] //Default Type for the password
        [Compare("Password")] //Will match the enterred value with password
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Alternative Email")]
        public string AltEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [NotMapped]
        [Display(Name = "Enter Another Member?")]
        public bool AnotherMember { get; set; }
    }
}
