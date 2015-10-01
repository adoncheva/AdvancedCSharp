using System;
using System.Collections.Generic;
using System.Linq;
//Problem 4.	First Larger Than Neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element



class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter several numbers?");
            char[] separators = { ' ', ',', ';' };
            string[] stringSplitNumbers = Console.ReadLine().Split(separators);
            int[] arrNumber = new int[stringSplitNumbers.Length];
            bool isInt;
            for (int i = 0; i < stringSplitNumbers.Length; i++)
            {
                do
                {
                    isInt = int.TryParse(stringSplitNumbers[i], out arrNumber[i]);
                    if (!isInt)
                    {
                        Console.WriteLine("Enter a floating-point number:");
                        stringSplitNumbers[i] = Console.ReadLine();
                    }
                } while (!isInt);
            }
            Console.WriteLine(GetIndexOfFirstLargerThanNeighbours(arrNumber));
        }
        public static int GetIndexOfFirstLargerThanNeighbours(int[] numbers)
        {
            int firstIndex = -1; ;
            bool larger=false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0 && numbers[i] > numbers[i + 1])
                {
                    larger = true;
                    firstIndex = 0;
                    break;
                }
                else if (i == numbers.Length - 1 && numbers[i] > numbers[i - 1])
                {
                    larger = true;
                    firstIndex = numbers.Length - 1;
                }
                else if (i != 0 && numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    larger = true;
                    firstIndex = i;
                    break;
                }
                else
                {
                    larger = false;
                }
            }
            return firstIndex;
        }
    }

