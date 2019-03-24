using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication2.Models
{
	public class Enrollment
	{
		public virtual int EnrollmentId { get; set; }
		public virtual int StudentId { get; set; }
		public virtual int CourseId { get; set; }

		[Required]
		[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
		public virtual string Grade { get; set; }

		public virtual Student StudentObject { get; set; }
		public virtual Course CourseObject { get; set; }
		public virtual bool IsActive { get; set; }

		[Required(ErrorMessage = "Assigned Campus")]
		public virtual string AssignedCampus { get; set; }

		[Required(ErrorMessage = "Enrolled in Semester")]
		public virtual string EnrollmentSemester { get; set; }

		[Required]
		//[StringLength(160, MinimumLength = 2018)]
		public virtual int EnrollmentYear { get; set; }

		//[Required]
		// Uncomment below
		//[InvalidChars("*", ErrorMessage = "Notes contains unacceptable characters!")]
		//public virtual string Notes { get; set; }
	}
}