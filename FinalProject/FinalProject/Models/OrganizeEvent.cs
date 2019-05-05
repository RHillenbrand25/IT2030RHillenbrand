using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
	public class OrganizeEvent
	{
		[Required]
		[StringLength(50)]
		public string EventTitle { get; set; }

		[StringLength(150)]
		public string EventDescription { get; set; }

		[Required]
		[Display(Name = "Start Date")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		// Event Start Date cannot be in the past
		public DateTime EventStartDate { get; set; }

		[Required]
		public DateTime EventStartTime  { get; set; }

		[Required]
		[Display(Name = "End Date")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		//[MyDate(ErrorMessage = "Back date entry not allowed")]
		//[DateGreaterThanAttribute(otherPropertyName = "StartDate", ErrorMessage = "End date must be greater than start date")]
		// Event End Date cannot be less than Event Start Date and Event End Date cannot be in the past 
		public DateTime EventEndDate { get; set; }

		[Required]
		public DateTime EventEndTime { get; set; }

		[Required]
		public string EventLocation { get; set; }

		public string EventType { get; set; }

		[Required]
		public string OrganizerName { get; set; }

		public string OrganizerContactInfo { get; set; }

		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
		public int MaxTickets { get; set; }

		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
		public int AvailableTickets { get; set; }
}
}