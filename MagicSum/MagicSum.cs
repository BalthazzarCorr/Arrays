namespace MagicSum
{
	using System;
	using System.Linq;

	class MagicSum
	{
		static void Main()
		{
			var inputArr = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			var inputNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < inputArr.Length; i++)
			{
				for (int j = i+1; j < inputArr.Length; j++)
				{
					if (inputArr[i]+inputArr[j] == inputNumber)
					{
						Console.WriteLine($"{inputArr[i]} {inputArr[j]} ");
					}
				}
			}



		}
	}
}
