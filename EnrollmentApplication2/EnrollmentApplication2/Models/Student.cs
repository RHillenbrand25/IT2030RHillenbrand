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
	}
}