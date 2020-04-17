﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPlanner.CustomValidations
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "Date value should be a future date";
        }

        protected override ValidationResult IsValid(object objValue, ValidationContext validationContext)
        {
            var dateValue = objValue as DateTime? ?? new DateTime();

            if (dateValue.Date < DateTime.Now.Date)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}
