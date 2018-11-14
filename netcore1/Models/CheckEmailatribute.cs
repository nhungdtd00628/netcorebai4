using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore1.Models
{
    public class CheckEmailatribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Student st = (Student)validationContext.ObjectInstance;
            string email = value as string;
            if(st.Email.Contains("nhungdoan"))
            {
                return new ValidationResult("da ton tai", new[] { "Email" });
            }
            return ValidationResult.Success;
        }
    }
}
