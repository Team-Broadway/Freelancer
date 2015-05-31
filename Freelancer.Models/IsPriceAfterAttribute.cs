using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Freelancer.Models
{
    public sealed class IsPriceAfterAttribute : ValidationAttribute
    {
        private readonly string testedPropertyName;

        public IsPriceAfterAttribute(string testedPropertyName)
        {
            this.testedPropertyName = testedPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyTestedInfo = validationContext.ObjectType.GetProperty(this.testedPropertyName);
            if (propertyTestedInfo == null)
            {
                return new ValidationResult(string.Format("unknown property {0}", this.testedPropertyName));
            }

            var propertyTestedValue = propertyTestedInfo.GetValue(validationContext.ObjectInstance, null);

            if (value == null || !(value is int))
            {
                return ValidationResult.Success;
            }

            if (propertyTestedValue == null || !(propertyTestedValue is int))
            {
                return ValidationResult.Success;
            }

            // Compare values
            if ((int)value >= (int)propertyTestedValue)
            {            
                return ValidationResult.Success;           
            }

            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

    }
}   
