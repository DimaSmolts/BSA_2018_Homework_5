using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSA_2018_Homework_4.BL.ServiceInterfaces;
using BSA_2018_Homework_4.DAL.RepositoryInterfaces;
using BSA_2018_Homework_4.DTOs;
using BSA_2018_Homework_4.DAL.Models;
using AutoMapper;

namespace BSA_2018_Homework_4.BL.Services
{
    public class CrewService : ICrewService
    {
		//private ICrewRepository crewRepository;
		private DAL.IUnitOfWork IunitOfWork;

		public CrewService(DAL.IUnitOfWork IunitOfWork)
		{
			this.IunitOfWork = IunitOfWork;
		}

		public void CreateCrew(CrewDTO item)
		{
			IunitOfWork.CrewRepository.Create(Mapper.Map<CrewDTO,Crew>(item));
		}

		public void DeleteCrewById(int id)
		{
			IunitOfWork.CrewRepository.Delete(id);
		}

		public CrewDTO GetCrewById(int id)
		{
			return Mapper.Map<Crew, CrewDTO>(IunitOfWork.CrewRepository.Get(id));
		}

		public List<CrewDTO> GetCrewCollection()
		{
			return Mapper.Map<List<Crew>, List<CrewDTO>>(IunitOfWork.CrewRepository.GetAll());
		}

		public void UpdateCrew(int id, CrewDTO item)
		{
			IunitOfWork.CrewRepository.Update(id,Mapper.Map<CrewDTO, Crew>(item));
		}
	}
}
