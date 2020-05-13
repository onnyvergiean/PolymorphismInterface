using System;


namespace PolymorphismInterface
{
	public class PrinterWindows : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Display Eror");

		}

		public void Print()
		{
			Console.WriteLine("Printing Eror");

		}
	}
}