using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SSGeek.Web.Models
{
    public class AlienWeightModel
    {
        public double WeightToConvert { get; set; }
		public string StartingWeight { get; set; }
		public string EndingWeight { get; set; }

		public double GetConvertedWeight()
		{
			//the statrting units to 
			Dictionary<string, double> conversionToPounds = new Dictionary<string, double>()
			{
				{"Earth", 1 },
				{"Mercury", 0.37 },
				{"Venus", .9},
				{"Mars", .38},
				{"Jupiter", 2.65 },
				{"Saturn", 1.13},
				{"Uranus", 1.09},
				{"Neptune", 1.43}
			};

			//math for weights
			double valueInPounds = WeightToConvert * conversionToPounds[EndingWeight];
			//double convertedWeight = valueInPounds / conversionToPounds[EndingWeight];

			return valueInPounds;
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