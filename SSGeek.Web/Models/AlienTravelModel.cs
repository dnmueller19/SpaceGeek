using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SSGeek.Web.Models
{
    public class AlienTravelModel
    {
		
		public double AgeToConvert { get; set; }

		public string Transportation { get; set; }
		public string EndingAge { get; set; }

		public double GetConvertedMiles()
		{
			//the statrting units to 
			Dictionary<string, double> conversionToMiles = new Dictionary<string, double>()
			{
				//miles from earth
				{"Earth", 1 },
				{"Mercury", 56974146},
				{"Venus",  25724767},
				{"Mars", 48678219 },
				{ "Jupiter", 390674710 },
				{"Saturn", 792248270},
				{"Uranus",  1692662530},
				{"Neptune", 2703959960}
			};

			//Dictionay for travel transport
			Dictionary<string, double> typeOfTransport = new Dictionary<string, double>()
			{
				//speed in mph

				{ "Walking", 3.0},
				{ "Car", 100.00},
				{ "BulletTrain", 200.00},
				{ "Boeing747", 570.00},
				{ "Concorde", 1350.00}
			};

			//math for travel
			//converts how many hours it will take to travel thsose distances 
			double milesToCovert = conversionToMiles[EndingAge] / typeOfTransport[Transportation];

			//convert hours to years
			double convertedToYears = milesToCovert / 8760;

			return Math.Round(convertedToYears, 2);
			
			
		}

		public double NewAge()
		{
			double howOld = AgeToConvert + GetConvertedMiles();

			return Math.Round(howOld, 2);
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
		public static List<SelectListItem> Transport = new List<SelectListItem>()
		{
			new SelectListItem(){ Text = "Walking", Value = "Walking"},
			new SelectListItem(){ Text = "Car", Value = "Car"},
			new SelectListItem(){ Text = "BulletTrain", Value = "BulletTrain"},
			new SelectListItem(){ Text = "Boeing 747", Value = "Boeing747"},
			new SelectListItem(){ Text = "Concorde", Value = "Concorde"}
		};
	}
}
