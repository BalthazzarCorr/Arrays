namespace KaminoFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class KaminoFactory
	{
		static void Main(string[] args)
		{
			var arrayLength = int.Parse(Console.ReadLine());
			var arrayDnaSequence = Console.ReadLine();
			var arra = new int[arrayLength];
			var listOfArrays = new List<Array>();
			var countOfSequences = 0;

			while (arrayDnaSequence != "Clone them!")
			{
				arra = arrayDnaSequence.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
					.ToArray();
				listOfArrays.Add(arra);
				countOfSequences++;
				arrayDnaSequence = Console.ReadLine();

			}

			foreach (var array in listOfArrays)
			{
				foreach (var element in array)
				{
					//var temp = string.Join(' ', element);
					Console.Write($"{element} ");
				}

				Console.WriteLine();
			}

			
		}
	}
}
