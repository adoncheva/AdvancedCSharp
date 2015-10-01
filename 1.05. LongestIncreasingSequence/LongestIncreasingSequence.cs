using System;
using System.Collections.Generic;
using System.Linq;
//Problem 5.	Longest Increasing Sequence
//Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them. 


    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter several numbers?");
            char[] separators = { ' ', ',', ';' };
            string[] splitNumbers = Console.ReadLine().Split(separators);
            double[] splitNumber = new double[splitNumbers.Length];
            bool isDouble;
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                do
                {
                    isDouble = double.TryParse(splitNumbers[i], out splitNumber[i]);
                    if (!isDouble)
                    {
                        Console.WriteLine("Enter a floating-point number:");
                        splitNumbers[i] = Console.ReadLine();
                    }
                } while (!isDouble);
            }
            int stop = 1,len;
            List<int>pos=new List<int>();
            List<int> start = new List<int>();
            start.Add(0);
          
            for (int i = 0; i < splitNumber.Length - 1; i++)
            {

                if (splitNumber[i] >= splitNumber[i + 1])
                {
                    stop++;
                    pos.Add(i + 1);
                    start.Add(i+1);
                }
             }
            pos.Add(splitNumber.Length);
          
            double[][] jagNumList = new double[stop][];
            for (int i = 0; i < stop; i++)
            {
                len = 0;
                for (int j = start[i];j < pos[i]; j++)
                {
                    len++; 
                }
                jagNumList[i] = new double[len];
            }
            int cnt=0;
			  for (int i = 0; i < jagNumList.Length; i++)
            {
                for (int j = 0; j < jagNumList[i].Length; j++)
                {
                    jagNumList[i][j] = splitNumber[cnt];
                    cnt++;
                   
                }
                if(cnt==splitNumber.Length) break;   
            }
			
           
            for (int i = 0; i < jagNumList.Length; i++)
            {
                 Console.WriteLine(string.Join(",",jagNumList[i]));
            }

            int max = 0, num = 0; 
            for (int i = 0; i < jagNumList.Length; i++)
            {
                if (jagNumList[i].Length > max)
                {
                    max = jagNumList[i].Length;
                    num = i;
                }
            }
            Console.Write("Longest: ");
            Console.Write(string.Join(",",jagNumList[num]));
            Console.WriteLine();
            

            
        }
    }

