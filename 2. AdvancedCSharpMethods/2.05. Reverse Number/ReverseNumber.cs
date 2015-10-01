using System;
using System.Collections.Generic;
//Problem 5.	Reverse Number
//Write a method that reverses the digits of a given floating-point number.

    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double doubleNumber; 
            string str1;
            bool parseSuccess;
            do
            {
                Console.Write("Enter a floating-point number: ");
                str1 = Console.ReadLine();
                parseSuccess = double.TryParse(str1, out doubleNumber);
                if (!parseSuccess)
                {
                    Console.WriteLine("Invalid data.You have to enter a floating-point number ");
                }
            } while (parseSuccess == false);
            double reversedDoubleNumber = GetReversedNumber(doubleNumber);
            Console.WriteLine(reversedDoubleNumber);
        }
      
        static public double GetReversedNumber(double number)
        {
            char[] strNumber = number.ToString().ToCharArray();
            Array.Reverse(strNumber);
            string revString = string.Join("", strNumber);
            double reversed = double.Parse(revString);
            return reversed;
        }
    }

