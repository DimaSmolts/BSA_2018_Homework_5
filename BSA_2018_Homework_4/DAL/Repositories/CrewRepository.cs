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
    public class CrewRepository : ICrewRepository
    {
		private List<Crew> crews = new List<Crew>();
		MyContext db;

		public CrewRepository(MyContext db)
		{
			this.db = db;
			//	using (StreamReader file = File.OpenText(Environment.CurrentDirectory + @"\Data\crews.json"))
			//{
			//	JsonSerializer serializer = new JsonSerializer();
			//	crews = (List<Crew>)serializer.Deserialize(file, typeof(List<Crew>));
			//}
		}

		public void SaveChanges()
		{
		//	File.WriteAllText(Environment.CurrentDirectory + @"\Data\crews.json",
			//	JsonConvert.SerializeObject(crews));
		}

		public List<Crew> GetAll()
		{
			return db.Crew.ToList();
		}

		public Crew Get(int id)
		{
			return db.Crew.Find(id);
		}

		public void Delete(int id)
		{
			Crew temp = db.Crew.Find(id);
			if (temp != null)
			{
				db.Crew.Remove(temp);				
			}				
		}

		public void Create(Crew item)
		{
			db.Crew.Add(item);
		}

		public void Update(int id, Crew item)
		{
			//Crew temp = crews.FirstOrDefault(t => t.Id == id);
			//if (temp != null)
			//{
			//	temp.Id = item.Id;
			//	temp.PilotId = item.PilotId;
			//	temp.StewardessIds = item.StewardessIds;

			//	SaveChanges();
			//}

			Crew temp = db.Crew.Find(id);
			if (temp != null)
			{
				db.Crew.Remove(temp);
				db.Crew.Add(item);
			}
		}
	}
}
