using System;
using System.Collections.Generic;
//Problem 1.	Sort Array of Numbers
//Write a program to read an array of numbers from the console, sort them and print them back on the console. The numbers should be entered from the console on a single line, separated by a space. 



    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter several numbers?");
            string strNumbers = Console.ReadLine();
            char[] separators = { ',', ' ' };
            string[] splitNumbers = strNumbers.Split(separators);
            double[] numbers = new double[splitNumbers.Length];
            bool isDouble;
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                do
                {
                    isDouble = double.TryParse(splitNumbers[i], out numbers[i]);
                    if (!isDouble)
                    {
                        Console.WriteLine("Enter a floating-point number:");
                        splitNumbers[i] = Console.ReadLine();
                    }
                } while (!isDouble);
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
    }

