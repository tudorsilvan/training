using System;
using System.Collections.Generic;

namespace Training
{
	public class Program
	{
		static void Main(string[] args)
		{
			var meetingRoom1 = new MeetingRooms(2,20);
			//Console.WriteLine(meetingRoom1.isRoomAvailable());
			var accesories = new Accesories();
			accesories.returnJabraDevice();


			Console.WriteLine(meetingRoom1.HasJabra());
			meetingRoom1.GetJabraDevice();
			Console.WriteLine(meetingRoom1.HasJabra());
			meetingRoom1.GetJabraDevice();

			Console.WriteLine(meetingRoom1.GetRoomNumber());
			//Console.WriteLine(accesories.isJabraAvailable());
			//Console.WriteLine(accesories.isJabraAvailable());
			//accesories.getJabraDevice();
			Users user1 = new Users();
			List<Users> listOfUsers = new List<Users>();

			meetingRoom1.BookMeetingRoom(Hours.Eleven, Hours.Eleven, listOfUsers);
		}
	}
}
