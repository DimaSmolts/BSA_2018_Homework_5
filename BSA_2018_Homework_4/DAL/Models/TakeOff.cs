using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA_2018_Homework_4.DAL.Models
{
	public class TakeOff
	{
		public int Id { get; set; }
		public Flight FlightNum { get; set; }
		public DateTime Date { get; set; }
		public Crew CrewId { get; set; }
		public Plane PlaneId { get; set; }
	}
}
