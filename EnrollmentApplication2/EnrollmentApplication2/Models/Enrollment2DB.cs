using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnrollmentApplication2.Models
{
    public class Enrollment2DB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Enrollment2DB() : base("name=Enrollment2DB")
        {
        }

		public System.Data.Entity.DbSet<EnrollmentApplication2.Models.Enrollment> Enrollments { get; set; }

		public System.Data.Entity.DbSet<EnrollmentApplication2.Models.Student> Students { get; set; }

		public System.Data.Entity.DbSet<EnrollmentApplication2.Models.Course> Courses { get; set; }
	}
}
