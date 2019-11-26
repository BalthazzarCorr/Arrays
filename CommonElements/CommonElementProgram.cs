namespace CommonElements
{
	using System;
	using System.Linq;

	class CommonElementProgram
	{
		static void Main()
		{
			var arr1 = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
			var arr2 = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();


			

			for (int i = 0; i < arr2.Length; i++)
			{
				for (int j = 0; j < arr1.Length; j++)
				{
					if (arr2[i] == arr1[j])
					{
						Console.Write($"{arr2[i]} ");
					}
				}
			}



		}
	}
}
