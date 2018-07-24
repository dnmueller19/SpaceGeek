using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Web.Models
{
    public class ForumPost
    {   
		public int ID { get; set; }
		[Required]
		[StringLength(20, ErrorMessage = "Get a shorter name")]
		public string Username { get; set; }

		[Required]
		[StringLength(10, ErrorMessage = "Get to the point")]
		public string Subject { get; set; }

		[Required]
		public string Message { get; set; }
		public DateTime PostDate { get; set; }
    }
}