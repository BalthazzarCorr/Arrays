namespace EqualSum
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	class EqualSumProgram
	{
		static void Main()
		{
		
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			List<int> index = new List<int>();

			for (int i = 0; i < nums.Length; i++)
			{
				var left = nums.Take(i).Sum();
				var right = nums.Skip(i + 1).Take(nums.Length - i).Sum();

				if ( left == right )
				{
					index.Add(i);
				}
			}

			if (index.Count > 0)
				Console.WriteLine(string.Join(", ", index));
			else
				Console.WriteLine("no");

		}


	}
}

