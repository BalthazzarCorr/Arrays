namespace EvenAndOddSubtraction
{
    using System;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[input.Length];


            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

            }

            var sumEven = 0;
            var sumOdd = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }

            var result = sumEven - sumOdd;

            Console.WriteLine(result);
        }
    }
}
