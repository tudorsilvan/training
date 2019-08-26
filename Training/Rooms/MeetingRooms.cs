using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
	 class MeetingRooms : Rooms
	{
		private bool isAvailable;
		private Accesories _accesories;
		private bool hasJabra;
		private Meeting meeting;
		public MeetingRooms(int roomNumber, int numberOfSeats) : base(roomNumber, numberOfSeats)
		{
			_accesories = new Accesories();
		}
		public bool IsRoomAvailable() {
			return isAvailable;
		}

		public void GetJabraDevice()
		{
			if (hasJabra) 
			{
				Console.WriteLine("Already has Jabra");
			}
			else if (_accesories.isJabraAvailable())
			{
				_accesories.getJabraDevice();
				hasJabra = true;
				Console.WriteLine("Jabra has been successfully booked.");
			}
			
		}
		
		public bool HasJabra()
		{
			return hasJabra;
		}

		public void BookMeetingRoom(Hours startHour, Hours endHour, List<Users> users)
		{
			
		}
	}
}
