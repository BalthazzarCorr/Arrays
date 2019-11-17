using System;

namespace DaysOfTheWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			var day = int.Parse(Console.ReadLine());

			var daysOfTheWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			if (day > 0 && day <= 7)
			{
				Console.WriteLine(daysOfTheWeek[day-1]);
			}
			else
			{
				Console.WriteLine("Invalid day!");
			}
		}
	}
}
