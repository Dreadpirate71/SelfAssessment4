using System;
using System.Linq;

namespace Chap_9_Exercise_11
{
    internal class Program
    {   
        static int[] ReverseOrder(params int[] numbers)
        {
            int [] result = numbers;
            Array.Reverse(result);
            return result;
        }

        static float CalculateAverage (params int[] numbers)
        {
            int arraySum = numbers.Sum();
            float arrayAverage = arraySum / numbers.Length;
            return arrayAverage;
        }

        static float SolveEquation (int num1, int num2)
        {
            float x = -1;
            float result  =  1;

            while (result != 0)
            {
                result = num1 * x + num2;
                x--;
            }
            return x;
        }
        static void Main(string[] args)
        {
            int[] numbersArray = { 3, 4, 2, 6, 8, 1 };
            int[] resultOption1 = ReverseOrder(numbersArray);
            float resultOption2 = CalculateAverage(numbersArray);
            float resultOption3 = SolveEquation(numbersArray[0], numbersArray[1]);
            Console.WriteLine(resultOption2);
            Console.WriteLine(string.Join(",", resultOption1));
            Console.WriteLine(resultOption3);
        }
    }
}
