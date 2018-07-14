﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSA_2018_Homework_4.DAL.Models
{
	public class Flight
	{
		
		public int FlightId { get; set; }
		public string DeperturePlace { get; set; }
		public DateTime DepartureTime { get; set; }
		public string ArrivalPlace { get; set; }
		public DateTime ArrivalTime { get; set; }
		// масив тікетів тут певно зайвий, адже у кожного тікета буде ід рейсу
		public List<Ticket> TicketId { get; set; }
	}
}
