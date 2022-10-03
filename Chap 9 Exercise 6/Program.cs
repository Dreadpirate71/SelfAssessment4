using System;
using System.Collections.Generic;

namespace Chap_9_Exercise_6
{
    internal class Program
    {
        static int GetFirstOccurence(int[] numbers)
        {
            int occurrenceIndex = 0;
            for (int i = 1; i < numbers.Length-1; i++)
            {
                //Console.WriteLine(numbers[i]);
                //Console.WriteLine(i);
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    occurrenceIndex = i;
                    return occurrenceIndex;
                }
                else
                {
                    occurrenceIndex = -1;
                }
            }
            return occurrenceIndex;
        }
        static void Main(string[] args)
        {
            int [] arrNumbers = new int [] { 2,4,6,6,7};
            int indexFirstOccurrence = GetFirstOccurence(arrNumbers);
            Console.WriteLine(indexFirstOccurrence);

        }
    }
}
