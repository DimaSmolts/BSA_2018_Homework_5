using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA_2018_Homework_4.DAL.Models
{
	public class Pilot
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime Birth { get; set; }
		public TimeSpan Experience { get; set; }
	}
}
