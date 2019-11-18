using System;

namespace RoundingNumbers
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string []  input = Console.ReadLine().Split(' ');

         

            int[] numbers = new int [input.Length];


            for (var i = 0; i < numbers.Length; i++)
            {

                numbers[i] = int.Parse(input[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
