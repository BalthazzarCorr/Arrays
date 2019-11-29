namespace TopIntegers
{
	using System;
	using System.Linq;

	class TopInteger
	{

		static void Main()
		{
			var inputArr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			for (int i = 0; i < inputArr.Length; i++)
			{
				var currentElement = inputArr[i];

				var isItBigger = true;

				for (int j = i+1; j < inputArr.Length; j++)
				{

					var nextElement = inputArr[j];

					if (currentElement <= nextElement)
					{
						isItBigger = false;
						
					}
				}

				if (isItBigger)
				{
					Console.Write($"{inputArr[i]} ");
				}
			}


		}
	}
}
