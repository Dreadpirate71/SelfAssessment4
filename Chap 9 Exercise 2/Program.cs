using System;
using System.Linq;

namespace Chap_9_Exercise_2
{
    internal class Program
    {
        static int GetMax(int int1, int int2)
        {
            int maxInt = Math.Max(int1, int2);
            return maxInt;
        }

        static bool testMax (int maximalFinal, params int[] numbers)
        {
            int maxArray = numbers.Max();
            if (maxArray == maximalFinal)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number:");
            int secondInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number:");
            int thirdInt = int.Parse(Console.ReadLine());

            int maximalOne = GetMax(firstInt, secondInt);
            int maximalTwo = GetMax(maximalOne, thirdInt);
            Console.WriteLine(maximalTwo);
            int [] inputNumbers = { firstInt, secondInt, thirdInt };
            bool maxTest = testMax(maximalTwo, inputNumbers);
            Console.WriteLine(maxTest);

        }
    }
}
