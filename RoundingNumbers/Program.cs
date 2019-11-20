using System;

namespace RoundingNumbers
{
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string []  input = Console.ReadLine().Split(' ');

         

            double[] numbers = new Double [input.Length];


            for (var i = 0; i < numbers.Length; i++)
            {

                numbers[i] = double.Parse(input[i]);
            }

            foreach (var number in numbers)
            {
                var temp = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {temp}");
            }
        }
    }
}
