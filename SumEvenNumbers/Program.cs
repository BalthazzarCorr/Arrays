namespace SumEvenNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            var input  = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int[] number = new int[input.Length];   
            

            for (int i = 0; i < input.Length; i++)
            {
                number[i] = int.Parse(input[i]);
            }

            var sumOfEvenNumbers = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==0)
                {
                    sumOfEvenNumbers += number[i];
                }
            }

            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}
