namespace KaminoFactory
{
	using System;
	using System.Linq;

	class KaminoFactory
	{
		static void Main(string[] args)
		{
			var arrayLength = int.Parse(Console.ReadLine());
			var arrayDnaSequence = Console.ReadLine();
			var arra = new int[arrayLength];
			var DnaArray = new int[arrayLength];
			var leftMostIndex = 0;
			var sumOfDna = 0;
			var lenghtOfSubSequence = 0;
			var numberOfTheSequence = 0;
			var numberOfCurrentSequence = 0;

			while (arrayDnaSequence != "Clone them!")
			{
				arra = arrayDnaSequence.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
					.ToArray();


				numberOfCurrentSequence++;


				int currentSum = 0;

				for (int i = 0; i < arra.Length; i++)
				{
					if (arra[i] == 1)
					{
						currentSum++;
					}
				}

				int currentLength = 0;
				int currentIndex = 0;

				for (int i = 0; i < arra.Length; i++)
				{
					if (arra[i]==1)
					{

						currentLength++;
						if (currentLength == 1 )
						{
							currentIndex = i;
						}

						if (currentLength > lenghtOfSubSequence || currentLength == lenghtOfSubSequence && (currentIndex < leftMostIndex || currentSum > sumOfDna))
						{
							lenghtOfSubSequence = currentLength;
							leftMostIndex = currentIndex;
							numberOfTheSequence = numberOfCurrentSequence;
							DnaArray = arra;
							sumOfDna = currentSum;

						}

					}
					else
					{
						currentIndex = 0;
						currentLength = 0;
					}

					
				}



				arrayDnaSequence = Console.ReadLine();

			}


			if (numberOfTheSequence == 0)
			{
				numberOfTheSequence = 1;
			}

			Console.WriteLine($"Best DNA sample {numberOfTheSequence} with sum: {sumOfDna}.");
			Console.WriteLine(string.Join(" ", DnaArray));

		}

	}
}
