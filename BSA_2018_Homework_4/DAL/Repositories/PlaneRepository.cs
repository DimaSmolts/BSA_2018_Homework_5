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
    public class PlaneRepository : IPlaneRepository
    {
		private List<Plane> planes = new List<Plane>();
		MyContext db;

		public PlaneRepository(MyContext db)
		{
			this.db = db;
		//	using (StreamReader file = File.OpenText(Environment.CurrentDirectory + @"\Data\planes.json"))
		//	{
		//		JsonSerializer serializer = new JsonSerializer();
		//		planes = (List<Plane>)serializer.Deserialize(file, typeof(List<Plane>));
		//	}
		}

		public void SaveChanges()
		{
			//File.WriteAllText(Environment.CurrentDirectory + @"\Data\planes.json",
				//JsonConvert.SerializeObject(planes));
		}

		public List<Plane> GetAll()
		{
			return db.PLane.ToList();
		}

		public Plane Get(int id)
		{
			return db.PLane.Find(id);
		}

		public void Delete(int id)
		{
			Plane temp = db.PLane.Find(id);
			if (temp != null)
			{
				db.PLane.Remove(temp);
			}				
		}

		public void Create(Plane item)
		{
			db.PLane.Add(item);
			//SaveChanges();
		}

		public void Update(int id, Plane item)
		{
			//Plane temp = planes.FirstOrDefault(t => t.Id == id);
			//if (temp != null)
			//{
			//	temp.Id = item.Id;
			//	temp.Name = item.Name;
			//	temp.Type = item.Type;
			//	temp.Made = item.Made;
			//	temp.Exploitation = item.Exploitation;
			//
			//	SaveChanges();
			//}

			Plane temp = db.PLane.Find(id);
			if (temp != null)
			{
				db.PLane.Remove(temp);
				db.PLane.Add(item);
			}
		}
	}
}
