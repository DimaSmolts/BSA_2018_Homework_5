using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BSA_2018_Homework_4.DAL.Models;

namespace BSA_2018_Homework_4.DAL
{
    public class MyContext : DbContext
    {
		public DbSet<Crew> Crew { get; set; }
		public DbSet<Flight> Flight { get; set; }
		public DbSet<TakeOff> TakeOff { get; set; }
		public DbSet<Ticket> Ticket { get; set; }
		public DbSet<Stewardess> Stewardess { get; set; }
		public DbSet<Pilot> Pilot { get; set; }
		public DbSet<Plane> PLane { get; set; }
		public DbSet<PlaneType> PlaneType { get; set; }

		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{
			this.Database.Migrate();
			//Seed();
			//this.SaveChanges();
		}

		public void Seed()
		{
			Pilot.RemoveRange(Pilot);
			Stewardess.RemoveRange(Stewardess);
			Ticket.RemoveRange(Ticket);
			Flight.RemoveRange(Flight);
			PLane.RemoveRange(PLane);
			PlaneType.RemoveRange(PlaneType);

			this.SaveChanges();

			if (!Crew.Any())
			{
				Crew.AddRange(
					new Crew()
					{
						PilotId = new Pilot()
						{
							Name = "Skyler",
							Surname = "Bunker",
							Birth = new DateTime(1998, 6, 28),
							Experience = new TimeSpan(0, 1, 3, 4)
						},
						StewardessIds = new List<Stewardess>()
						{
							new Stewardess
							{
								Name = "Zelda",
								Surname = "Gouse",
								Birth = new DateTime(1998, 6, 28),
							},
							new Stewardess
							{
								Name = "Anna",
								Surname = "Rosser",
								Birth = new DateTime(1998, 6, 28),
							}
						}
					},
					new Crew()
					{
						PilotId = new Pilot()
						{
							Name = "Garry",
							Surname = "Murdoch",
							Birth = new DateTime(1998, 6, 28),
							Experience = new TimeSpan(0, 1, 3, 4)
						},
						StewardessIds = new List<Stewardess>()
						{
							new Stewardess
							{
								Name = "Bobina",
								Surname = "Vaccaro",
								Birth = new DateTime(1998, 6, 28),
							},
							new Stewardess
							{
								Name = "Sharron",
								Surname = "Herwitz",
								Birth = new DateTime(1998, 6, 28),
							}
						}
					},
					new Crew()
					{
						PilotId = new Pilot()
						{
							Name = "Dennisson",
							Surname = "Keegan",
							Birth = new DateTime(1998, 6, 28),
							Experience = new TimeSpan(0, 1, 3, 4)
						},
						StewardessIds = new List<Stewardess>()
						{
							new Stewardess
							{
								Name = "Isa",
								Surname = "Dorwart",
								Birth = new DateTime(1998, 6, 28),
							}
						}
					});
			}


			if (!Flight.Any())
			{
				Flight.Add(
					new Flight()
					{
						DeperturePlace = "Kyiv",
						DepartureTime = new DateTime(1998, 6, 28),
						ArrivalPlace = "London",
						ArrivalTime = new DateTime(1998, 6, 28),
						TicketId = new List<Ticket>()
						{
							new Ticket()
							{
								Price = 500
							},
							new Ticket()
							{
								Price = 800
							}
						}						
					});
				Flight.Add(
					new Flight()
					{
						DeperturePlace = "Kyiv",
						DepartureTime = new DateTime(1998, 6, 28),
						ArrivalPlace = "Manchester",
						ArrivalTime = new DateTime(1998, 6, 28),
						TicketId =  new List<Ticket>()
						{
							new Ticket()
							{
								Price = 800
							},
							new Ticket()
							{
								Price = 800
							},
							new Ticket()
							{
								Price = 1000
							}
						}
					});
				Flight.Add(
					new Flight()
					{
						DeperturePlace = "Kyiv",
						DepartureTime = new DateTime(1998, 6, 28),
						ArrivalPlace = "Frankfurt",
						ArrivalTime = new DateTime(1998, 6, 28),
						TicketId =  new List<Ticket>()
						{
							new Ticket()
							{
								Price = 600
							},
							new Ticket()
							{
								Price = 600
							}
						}
					});
			}
			if (!PlaneType.Any())
			{
				PlaneType.AddRange(
					new PlaneType()
					{
						Model = "Airbus A310",
						Places = 183,
						CarryCapacity = 164000,
						Plane = new List<Plane>()
						{
							new Plane()
							{
								Name = "Skyshark",
								Made = new DateTime(1998, 6, 28),
								Exploitation = new TimeSpan(0, 1, 3, 4)
							}
						}
					},
					new PlaneType()
					{
						Model = "Boeing-777",
						Places = 235,
						CarryCapacity = 242,
						Plane = new List<Plane>()
						{
							new Plane()
							{
								Name = "Dragon",
								Made = new DateTime(1998, 6, 28),
								Exploitation = new TimeSpan(0, 1, 3, 4)
							},
							new Plane()
							{
								Name = "AirKing",
								Made = new DateTime(1998, 6, 28),
								Exploitation = new TimeSpan(0, 1, 3, 4)
							},
							new Plane()
							{
								Name = "Kondor",
								Made = new DateTime(1998, 6, 28),
								Exploitation = new TimeSpan(0, 1, 3, 4)
							}
						}
					});
			}
		}
	}
}
