using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.WEB.Portal.Models
{
    internal class DateGreaterThanAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var leave = (LeaveModel)validationContext.ObjectInstance;

            if (leave.LeaveFromDate.Year.Equals(1))
                return new ValidationResult("Leave from date is required.");
            if (leave.LeaveToDate.Year.Equals(1))
                return new ValidationResult("Leave too date is required.");

            var dateDiff = leave.LeaveToDate - leave.LeaveFromDate;
            return (dateDiff.Days >= 0)
                ? ValidationResult.Success
                : new ValidationResult("Leave too date must be greater than leave from date");
        }
    }
}