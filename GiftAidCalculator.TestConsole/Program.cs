using System;

namespace GiftAidCalculator.TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// Calc Gift Aid Based on Previous
			Console.WriteLine("Please Enter donation amount:");
			Console.WriteLine(GiftAidAmount(decimal.Parse(Console.ReadLine())));
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}

		static decimal GiftAidAmount(decimal donationAmount)
		{
			var gaRatio = 17.5m / (100 - 17.5m);
			return donationAmount * gaRatio;
		}
	}
}
