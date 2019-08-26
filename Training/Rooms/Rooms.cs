using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
	public abstract class Rooms
	{
		private int _roomNumber;
		private int _numberOfSeats;

		public Rooms(int roomNumber, int numberOfSeats)
		{
			_roomNumber = roomNumber;
			_numberOfSeats = numberOfSeats;
		}

		public int GetRoomNumber() {
			return _roomNumber;
		}

		public int GetNumberOfSeats()
		{
			return _numberOfSeats;
		}
	}
}

