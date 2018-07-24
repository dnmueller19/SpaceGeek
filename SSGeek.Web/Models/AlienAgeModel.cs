using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SSGeek.Web.Models
{
	public class AlienAgeModel
	{
		
		public double AgeToConvert { get; set; }
		
		public string StartingAge { get; set; }
		public string EndingAge { get; set; }

		public double GetConvertedAge()
		{
			//the statrting units to 
			Dictionary<string, double> conversionToYears = new Dictionary<string, double>()
			{
				//year
				{"Earth", 1 },
				{"Mercury", .24 },
				{"Venus", .6155 },
				{"Mars", 1.55 },
				{ "Jupiter", 11.862 },
				{"Saturn", 29.456},
				{"Uranus", 84.07 },
				{"Neptune", 164.81}
			};

			//math for weights
			double valueInYears = AgeToConvert / conversionToYears[EndingAge];
			//double convertedWeight = valueInPounds / conversionToPounds[EndingWeight];

			return valueInYears;
		}

		
		public static List<SelectListItem> Planet = new List<SelectListItem>()
		{
			new SelectListItem() { Text = "Earth", Value="Earth"},
			new SelectListItem() { Text = "Mercury", Value="Mercury"},
			new SelectListItem() { Text = "Venus", Value="Venus"},
			new SelectListItem() { Text = "Mars", Value="Mars"},
			new SelectListItem() { Text = "Jupiter", Value="Jupiter"},
			new SelectListItem() { Text = "Saturn", Value="Saturn"},
			new SelectListItem() { Text = "Uranus", Value="Uranus"},
			new SelectListItem() { Text = "Neptune", Value="Neptune"}
		};
	}
}
