﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA_2018_Homework_4.DAL.Models;
using BSA_2018_Homework_4.DAL.RepositoryInterfaces;
using Newtonsoft.Json;
using System.IO;

namespace BSA_2018_Homework_4.DAL.Repositories
{
    public class TicketRepository : ITicketRepository
    {
		private List<Ticket> tickets = new List<Ticket>();
		MyContext db;

		public TicketRepository(MyContext db)
		{
			this.db = db;
			//using (StreamReader file = File.OpenText(Environment.CurrentDirectory + @"\Data\tickets.json"))
			//{
		//		JsonSerializer serializer = new JsonSerializer();
		//		tickets = (List<Ticket>)serializer.Deserialize(file, typeof(List<Ticket>));
		//	}
		}

		public void SaveChanges()
		{
		//	File.WriteAllText(Environment.CurrentDirectory + @"\Data\tickets.json",
		//		JsonConvert.SerializeObject(tickets));
		}

		public List<Ticket> GetAll()
		{
			return db.Ticket.ToList();
		}

		public Ticket Get(int id)
		{
			return db.Ticket.Find(id);
		}

		public void Delete(int id)
		{
			Ticket temp = db.Ticket.Find(id);
			if (temp != null)
			{
				db.Ticket.Remove(temp);
			}				
		}

		public void Create(Ticket item)
		{
			db.Ticket.Add(item);
		}

		public void Update(int id, Ticket item)
		{
			//Ticket temp = tickets.FirstOrDefault(t => t.Id == id);
			//if (temp != null)
			//{
			//	temp.Id = item.Id;
			//	temp.Price = item.Price;
			//temp.FlightNum = item.FlightNum;

			//	SaveChanges();
			//}
			Ticket temp = db.Ticket.Find(id);
			if (temp != null)
			{
				db.Ticket.Remove(temp);
				db.Ticket.Add(item);
			}
		}
	}
}
