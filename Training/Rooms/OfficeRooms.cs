using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
	class OfficeRooms : Rooms
	{
		private int occupiedSeats { get; set; }

		public OfficeRooms(int roomNumber, int numberOfSeats, int occupiedSeats) : base(roomNumber, numberOfSeats)
		{
			this.occupiedSeats = occupiedSeats;
		}
	}
}
