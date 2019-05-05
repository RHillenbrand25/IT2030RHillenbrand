using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
	public class CreateEventType
	{
		[StringLength(50)]
		public string Type { get; set; }
	}
}