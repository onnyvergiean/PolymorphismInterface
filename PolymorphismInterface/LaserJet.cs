using System;


namespace PolymorphismInterface
{
	public class LaserJet : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Canon display dimension : 12*12");

		}

		public void Print()
		{
			Console.WriteLine("Canon printer printing....");
	
		}
	}
}