namespace Equal_Arrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = 0;

            var tempSum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                tempSum += arr1[i];

                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                    

                }
                
            }

            if (sum == tempSum)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
           


        }
    }
}
