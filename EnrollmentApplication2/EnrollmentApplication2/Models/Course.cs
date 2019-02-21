using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication2.Models
{
	public class Course
	{
		[Required(ErrorMessage = "Course ID")]
		public virtual int CourseId { get; set; }

		[Required(ErrorMessage = "Course Title")]
		[StringLength(150)]
		public virtual string Title { get; set; }

		public virtual string Description { get; set; }

		[Required(ErrorMessage = "Number of credits")]
		[Range(1, 4)]
		public virtual string Credits { get; set; }
	}
}