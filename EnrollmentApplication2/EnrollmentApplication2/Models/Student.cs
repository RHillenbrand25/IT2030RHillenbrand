using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication2.Models
{
	public class Student
	{
		[Required(ErrorMessage = "Student ID")]
		public virtual int StudentId { get; set; }

		[Required(ErrorMessage = "Last Name")]
		[StringLength(50)]
		public virtual string LastName { get; set; }

		[Required(ErrorMessage = "First Name")]
		[StringLength(50)]
		public virtual string FirstName { get; set; }

		public string Address1 { get; set; }

		[Compare(nameof(Address1), ErrorMessage = "Address2 cannot be the same as Address1")]
		public string Address2 { get; set; }

		public string City { get; set; }

		[StringLength(5, ErrorMessage = "Enter a 5 digit Zipcode")]
		public string Zipcode { get; set; }

		[StringLength(2, ErrorMessage = "Enter a 2 digit State code")]
		public string State { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (Address2 = Address1)
			{
				yield return (new ValidationResult("Address2 cannot be the same as Address1"));
			}
			if (Zipcode = 5)
			{
				yield return (new ValidationResult("Zipcode must be a 5 digit Zipcode"));
			}
			if (State = 2)
			{
				yield return (new ValidationResult("State must be a 2 digit State code"));
			}

			throw new NotImplementedException();
		}	
	}
}