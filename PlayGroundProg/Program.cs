using System;

namespace PlayGroundProg
{
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			var  arr = new int[]
			{
				1,2,3,4,5,6,7,8
			};

			var value = arr.Take(5).Sum();
			Console.WriteLine(value);
		}
	}
}
