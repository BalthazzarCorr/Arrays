namespace MaxSequenceOfEqualElements
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class MaxSeq
	{
		static void Main()
		{
			//var inputArr = Console.ReadLine()
			//	.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			//	.Select(int.Parse)
			//	.ToArray();

			//var counter = new List<int>();

			//counter.Add(inputArr[0]);

			//for (int i = 0; i < inputArr.Length; i++)
			//{



			//	var value = inputArr[i];
			//	if (counter.Contains(value))
			//	{
			//		counter.Add(inputArr[i]);
			//	}
			//	else
			//	{

			//		counter.Clear();
			//		counter.Add(inputArr[i]);
			//	}

			//	if (counter.Count >= 2)
			//	{
			//		Console.WriteLine(string.Join(' ', counter));
			//		break;
			//	}


			//}

			List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			
			int maxnumbers = 0;
			int count = 1;
			int maxcount = 1;
			int pos = 0;
			while (pos < numbers.Count - 1)
			{

				if (numbers[pos] == numbers[pos + 1])
				{
					count++;

					if (count > maxcount)
					{
						maxcount = count;
						maxnumbers = numbers[pos];
					}

				}
				else
				{
					count = 1;
				}
				pos++;
				if (maxcount == 1)
				{
					maxnumbers = numbers[0];
				}
			}
			for (int i = 0; i < maxcount; i++)
			{
				Console.Write(maxnumbers);
				Console.Write(" ");

			}

		}
	}
}