using System;

namespace SignalR.EntityLayer.Entities
{
	public class Booking
	{
		public int BookID { get; set; }
		public string Name { get; set; }
		public string phone { get; set; }
		public string Mail { get; set; }
		public int PersonCount { get; set; }
		public DateTime Date { get; set; }

	}
}
