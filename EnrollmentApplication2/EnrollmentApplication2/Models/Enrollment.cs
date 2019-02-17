using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication2.Models
{
	public class Enrollment
	{
		public virtual int EnrollmentId { get; set; }
		public virtual int StudentId { get; set; }
		public virtual int CourseId { get; set; }
		public virtual string Grade { get; set; }
		public virtual Student StudentObject { get; set; }
		public virtual Course CourseObject { get; set; }
		public virtual bool IsActive { get; set; }
		public virtual string AssignedCampus { get; set; }
		public virtual string EnrollmentSemester { get; set; }
		public virtual int EnrollmentYear { get; set; }
	}
}