using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA_2018_Homework_4.DAL.Models
{
	public class Crew
	{
		public int Id { get; set; }
		public Pilot PilotId { get; set; }
		public List<Stewardess> StewardessIds { get; set; }
	}
}
