using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WEBAPIRESTFULL.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string name = value.ToString();

                if (name.Contains("Giomar"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Entrar com um nome vãlido pls.");
                }
            }
            else
            {
                return new ValidationResult("" + validationContext.DisplayName + " campo obrigatório.");
            }
        }
    }
}