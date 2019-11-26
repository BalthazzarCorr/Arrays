namespace ArrRotation
{
	using System;
	using System.Linq;

	class ArrRotationProg
	{
		static void Main()
		{
			var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var countOfRotations = int.Parse(Console.ReadLine());

			int [] tempArr = new int[inputArr.Length];

			for (int i = 0; i < countOfRotations; i++)
			{
				tempArr[inputArr.Length-1] = inputArr[0];

				for (int j = 0; j < inputArr.Length-1; j++)
				{
					tempArr[j] = inputArr[j + 1];
				}


				for (int j = 0; j < tempArr.Length; j++)
				{
					inputArr[j] = tempArr[j];
				}
			}

			Console.WriteLine(string.Join(' ',inputArr));
		}
	}
}
