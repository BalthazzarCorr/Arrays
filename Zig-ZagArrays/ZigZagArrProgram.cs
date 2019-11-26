namespace Zig_ZagArrays
{
	using System;
	using System.Linq;


	class ZigZagArrProgram
	{
		static void Main()
		{
			var inputN = int.Parse(Console.ReadLine());
			int[] arr1 = new int[inputN];
			int[] arr2 = new int[inputN];
			var count = 0;
			for (int i = 0; i < inputN; i++)
			{

				var temp = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				if (count % 2 == 0)
				{
					arr1[i] = temp[0];
					arr2[i] = temp[1];
				}
				else
				{

					arr1[i] = temp[1];
					arr2[i] = temp[0];
				}

				count++;
			}

			Console.WriteLine(String.Join(' ' , arr1));
			Console.WriteLine(String.Join(' ' , arr2));
		}
	}
}
