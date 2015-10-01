using System;
using System.Collections.Generic;
//Problem 2.	Sort Array of Numbers Using Selection Sort
//Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
//Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 


    class SortArraysSelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter several numbers?");
            string strNumbers = Console.ReadLine();
            char[] separators = { ',', ' ' };
            string[] splitNumbers = strNumbers.Split(separators);
            double[] numbers = new double[splitNumbers.Length];
            bool isDouble;
            double temp;
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
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i]>numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
    }

