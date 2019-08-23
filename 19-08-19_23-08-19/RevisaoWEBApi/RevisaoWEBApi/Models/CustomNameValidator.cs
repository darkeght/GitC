using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                if(value.ToString().Contains("GIOMAR"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Muito triste com você.");
                }
            }

            return new ValidationResult("O campo:" + validationContext.DisplayName
                + " é um campo obrigatorio.");
        }
    }
}