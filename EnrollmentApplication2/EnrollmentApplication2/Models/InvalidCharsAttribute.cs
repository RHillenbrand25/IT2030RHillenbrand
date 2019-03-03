using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication2.Models
{
	public class InvalidCharsAttribute : ValidationAttribute
	{
		public InvalidCharsAttribute()
		{

		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			return ValidationResult.Success;
			//return base.IsValid(value, validationContext);
		}
	}
}