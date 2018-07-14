using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA_2018_Homework_4.DAL.Models;
using BSA_2018_Homework_4.DAL.RepositoryInterfaces;
using Newtonsoft.Json;
using System.IO;

namespace BSA_2018_Homework_4.DAL.Repositories
{
    public class FlightRepository : IFlightRepository
    {
		private List<Flight> flights = new List<Flight>();
		MyContext db;

		public FlightRepository(MyContext db)
		{
			this.db = db;
		//	using (StreamReader file = File.OpenText(Environment.CurrentDirectory + @"\Data\flights.json"))
		//	{
			//	JsonSerializer serializer = new JsonSerializer();
			//	flights = (List<Flight>)serializer.Deserialize(file, typeof(List<Flight>));
			//}
		}

		public void SaveChanges()
		{
			//File.WriteAllText(Environment.CurrentDirectory + @"\Data\flights.json",
			//	JsonConvert.SerializeObject(flights));
		}

		public List<Flight> GetAll()
		{
			return db.Flight.ToList();
		}

		public Flight Get(int id)
		{
			return db.Flight.Find(id);
		}

		public void Delete(int id)
		{
			Flight temp = db.Flight.Find(id);
			if (temp != null)
			{
				db.Flight.Remove(temp);
			}				
		}

		public void Create(Flight item)
		{
			db.Flight.Add(item);
		}

		public void Update(int id,Flight item)
		{
		//	Flight temp = flights.FirstOrDefault(t => t.FlightNum == id);
			//if (temp != null)
			//{
			//	temp.FlightNum = item.FlightNum;
			//	temp.DeperturePlace = item.DeperturePlace;
			//	temp.DepartureTime = item.DepartureTime;
				//temp.ArrivalPlace = item.ArrivalPlace;
				//temp.ArrivalTime = item.ArrivalTime;
				//temp.TicketId = item.TicketId;

				//SaveChanges();
			//}

			Flight temp = db.Flight.Find(id);
			if (temp != null)
			{
				db.Flight.Remove(temp);
				db.Flight.Add(item);
			}
		}
	}
}
