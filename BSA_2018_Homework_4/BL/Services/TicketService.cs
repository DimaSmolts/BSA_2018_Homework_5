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
    public class TicketService : ITicketService
    {
		private DAL.IUnitOfWork IunitOfWork;

		public TicketService(DAL.IUnitOfWork IunitOfWork)
		{
			this.IunitOfWork = IunitOfWork;
		}

		public List<TicketDTO> GetTicketCollection()
		{
			return Mapper.Map<List<Ticket>, List<TicketDTO>>(IunitOfWork.TicketRepository.GetAll());
		}
		public TicketDTO GetTicketById(int id)
		{
			return Mapper.Map<Ticket, TicketDTO>(IunitOfWork.TicketRepository.Get(id));
		}
		public void DeleteTicketById(int id)
		{
			IunitOfWork.TicketRepository.Delete(id);
		}
		public void CreateTicket(TicketDTO item)
		{
			IunitOfWork.TicketRepository.Create(Mapper.Map<TicketDTO, Ticket>(item));
		}
		public void UpdateTicket(int id, TicketDTO item)
		{
			IunitOfWork.TicketRepository.Update(id, Mapper.Map<TicketDTO, Ticket>(item));
		}
	}
}
