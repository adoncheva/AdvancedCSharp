using System;
using System.Collections.Generic;
using System.Linq;
//Problem 3.	Larger Than Neighbours
//Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours



    class LargerThanNeighbours
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



            for (int index = 0; index < arrNumber.Length; index++)
            {

                Console.WriteLine(isLargerThanNeighbours(arrNumber,index));
            }
        }
        public static bool isLargerThanNeighbours (int[] numbers,int i)
        {
            bool larger=false;
         
                if (i == 0 && numbers[i]>numbers[i+1])
                {
                    larger = true;
                }
                else if (i==numbers.Length-1 && numbers[i]>numbers[i-1])
                {
                    larger = true;
                   
                }
                else if (i!=0 && numbers[i-1]<numbers[i] && numbers[i]>numbers[i+1])
                {
                    larger = true;
                }
           
            return larger;
        }
    }
    

