using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA_2018_Homework_4.DAL.Models
{
	public class PlaneType
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public int Places { get; set; }
		public int CarryCapacity { get; set; }
		public List<Plane> Plane { get; set; }
	}
}
