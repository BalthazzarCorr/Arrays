using System;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			var numberOfElements = int.Parse(Console.ReadLine());

			var numbers = new int[numberOfElements];

			//saving values
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = i + 1;
			}

			//reading values 

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}

		}
	}
}
