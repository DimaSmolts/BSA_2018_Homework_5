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
    public class TakeOffService : ITakeOffService
    {
		private DAL.IUnitOfWork IunitOfWork;

		public TakeOffService(DAL.IUnitOfWork IunitOfWork)
		{
			this.IunitOfWork = IunitOfWork;
		}

		public void CreateTakeOff(TakeOffDTO item)
		{
			IunitOfWork.TakeOffRepository.Create(Mapper.Map<TakeOffDTO, TakeOff>(item));
		}

		public void DeleteTakeOffById(int id)
		{
			IunitOfWork.TakeOffRepository.Delete(id);
		}

		public TakeOffDTO GetTakeOffById(int id)
		{
			return Mapper.Map<TakeOff,TakeOffDTO>(IunitOfWork.TakeOffRepository.Get(id));
		}

		public List<TakeOffDTO> GetTakeOffCollection()
		{
			return Mapper.Map<List<TakeOff>,List<TakeOffDTO>>(IunitOfWork.TakeOffRepository.GetAll());
		}

		public void UpdateTakeOff(int id, TakeOffDTO item)
		{
			IunitOfWork.TakeOffRepository.Update(id, Mapper.Map<TakeOffDTO, TakeOff>(item));
		}
	}
}
