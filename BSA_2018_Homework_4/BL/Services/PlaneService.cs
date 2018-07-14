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
    public class PlaneService : IPlaneService
    {
		//private IPlaneRepository planeRepo;

		private DAL.IUnitOfWork IunitOfWork;

		public PlaneService(DAL.IUnitOfWork IunitOfWork)
		{
			this.IunitOfWork = IunitOfWork;
		}

		public List<PlaneDTO> GetPlaneCollection()
		{
			return Mapper.Map<List<Plane>, List<PlaneDTO>>(IunitOfWork.PlaneRepository.GetAll());
		}
		public PlaneDTO GetPlaneById(int id)
		{
			return Mapper.Map<Plane,PlaneDTO>(IunitOfWork.PlaneRepository.Get(id));
		}
		public void DeletePlaneById(int id)
		{
			IunitOfWork.PlaneRepository.Delete(id);
		}
		public void CreatePlane(PlaneDTO item)
		{
			IunitOfWork.PlaneRepository.Create(Mapper.Map<PlaneDTO, Plane>(item));
		}
		public void UpdatePlane(int id, PlaneDTO item)
		{
			IunitOfWork.PlaneRepository.Update(id, Mapper.Map<PlaneDTO, Plane>(item));
		}

	}
}
