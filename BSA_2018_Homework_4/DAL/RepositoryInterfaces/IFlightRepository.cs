﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA_2018_Homework_4.DAL.Models;

namespace BSA_2018_Homework_4.DAL.RepositoryInterfaces
{
    public interface IFlightRepository
    {
		List<Flight> GetAll();
		Flight Get(int id);
		void Delete(int id);
		void Create(Flight item);
		void Update(int id, Flight item);
	}
}
