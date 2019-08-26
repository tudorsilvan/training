using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
	class Accesories
	{
		private static int numberOfJabras;

		public bool isJabraAvailable()
		{
			return numberOfJabras > 0;
		}

		public bool getJabraDevice()
		{
			if (isJabraAvailable())
			{
				numberOfJabras--;
				Console.WriteLine("There are still " + numberOfJabras + " available");
				return true;
			}

			Console.WriteLine("There are no available devices");
			return false;
		}

		public void returnJabraDevice()
		{
			numberOfJabras++;
			Console.WriteLine("There are " + numberOfJabras + " available");
		}
	}
}
