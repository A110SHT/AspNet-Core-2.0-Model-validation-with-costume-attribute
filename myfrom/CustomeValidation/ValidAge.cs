using myfrom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myfrom.CustomeValidation
{

    public class ValidAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as FormModel;

            var db = model.DOB.AddYears(100);

            if (model == null)
                throw new ArgumentException("Attribute not applied on Model");

            if (model.DOB > DateTime.Now.Date)
                return new ValidationResult($"{validationContext.DisplayName} cannot be upcoming Date.");
            if (model.DOB > DateTime.Now.Date.AddYears(-16))
                  return new ValidationResult("You must be 17 years old.");
            if (db < DateTime.Now.Date)
                return new ValidationResult("We rescept you but we cannot accept this date. over 100 years old.");
            return ValidationResult.Success;
        }
    }

}
