using Microsoft.AspNetCore.Mvc.Rendering;
using myfrom.CustomeValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myfrom.Models
{
    public class FormModel
    {
        //public IEnumerable<GenderModel> Genders {
        //    get
        //    {
        //        return ((GenderEnum[])Enum.GetValues(typeof(GenderEnum))).Select(c => new SelectListItem() { Value = c.ToString() });
        //    }
        //}
        public IEnumerable<SelectListItem> LstCountry { get
            {
                return new Country().ListCountry();
            }
        }
        public int ID { get; set; }
        [Required, Display(Name = "Full Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string FullName { get; set; }

        [Required, Display(Name = "Address")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Address { get; set; }

        [Required, Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required, Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "You must provide a Mobile Number."), Display(Name = "Mobile No.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string MobileNo { get; set; }

        [Required, Display(Name = "Country")]
        public string Country { get; set; }

        [Required, Display(Name = "Date of Birth")]
        [ValidAge] // we create our own validation attribute
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class GenderModel
    {
        public string Gender { get; set; }
    }
    public enum GenderEnum
    {
        Male,
        Female,
        Other
    }
}
