using System;

namespace Chap_9_Exercise_3
{
    internal class Program
    {
        static string PrintEnglishDigit(string number)
        {
            char lastNumberOfString = number[number.Length - 1];
            string digitEnglish = "";
            switch (lastNumberOfString)
            {
                case '0':
                    digitEnglish = "Zero";
                    return digitEnglish;
                case '1':
                    digitEnglish = "One";
                    return digitEnglish;
                case '2':
                    digitEnglish = "Two";
                    return digitEnglish;
                case '3':
                    digitEnglish = "Three";
                    return digitEnglish;
                case '4':
                    digitEnglish = "Four";
                    return digitEnglish;
                case '5':
                    digitEnglish = "Five";
                    return digitEnglish;
                case '6':
                    digitEnglish = "Six";
                    return digitEnglish;
                case '7':
                    digitEnglish = "Seven";
                    return digitEnglish;
                case '8':
                    digitEnglish = "Eight";
                    return digitEnglish;
                case '9':
                    digitEnglish = "Nine";
                    return digitEnglish;
                default:
                    return digitEnglish;
            }   


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string inputNumber = Console.ReadLine();
            string lastDigitInEnglish = PrintEnglishDigit(inputNumber);
            Console.WriteLine(lastDigitInEnglish);
        }
    }
}
