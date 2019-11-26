namespace Train
{
	using System;
	class Program
	{
		static void Main(string[] args)
		{
			var intputTrain = int.Parse(Console.ReadLine());
			var passengerArray = new int[intputTrain];
			var sum = 0;


			for (int i = 0; i < passengerArray.Length; i++)
			{
				var temp = int.Parse(Console.ReadLine());
				passengerArray[i] = temp;
				sum += passengerArray[i];

			}
			Console.WriteLine(string.Join(' ', passengerArray));

			Console.WriteLine($"{sum}");
		}
	}
}
