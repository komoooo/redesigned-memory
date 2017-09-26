using System;

namespace rectanglearea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = double.Parse (Console.ReadLine ());
			double b = double.Parse (Console.ReadLine ());

			double sum = (a * b);

			Console.WriteLine ("{0:F2}",sum);
		}
	}
}
