using System;
using System.Linq;

namespace Reverse
{
	class Program
	{
		static void Main()
		{
			var numberOfElements = int.Parse(Console.ReadLine());

			var elements = new int[numberOfElements];

			for (int i = 0; i < numberOfElements; i++)
			{
				elements[i] = int.Parse(Console.ReadLine());
			}

			var reverseElements = elements.Reverse();

			Console.Write(string.Join(' ',reverseElements));

		}
	}
}
