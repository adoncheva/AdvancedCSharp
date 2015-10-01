using System;
using System.Collections.Generic;
using System.Linq;
//Problem 6.	Subset Sums
//Write a program that reads from the console a number N and an array of integers given on a single line. Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first. In case there aren't any subsets with the desired sum, print "No matching subsets." 


    class SubsetSums
    {
        static void Main(string[] args)
        {
            int intNum;
            bool isInt;
            char[] separators = { ' ', ',', ';' };
            
            do
            {
                Console.Write("Please enter an integer: ");
                isInt = int.TryParse(Console.ReadLine(), out intNum);
                if (!isInt)
                {
                    Console.WriteLine("You must enter an integer between - 2 147 483 648 and 2 147 483 647: ");
                }
            } while (!isInt);
            Console.WriteLine("Enter several numbers?");
            string[] splitNumbers = Console.ReadLine().Trim().Split(separators);
            int[] splitNumber = new int[splitNumbers.Length];
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                do
                {
                    isInt = int.TryParse(splitNumbers[i], out splitNumber[i]);
                    if (!isInt)
                    {
                        Console.WriteLine("Enter an integer");
                        splitNumbers[i] = Console.ReadLine();
                    }
                } while (!isInt);
            }
           
            isSubsetSum(splitNumber, intNum);
        }
       public static void isSubsetSum(int[] set, int sum)
        {
            bool found=false;
            int combinations = 1 << set.Length;
          
            for (int i = 1; i < combinations; i++)
            {
                List<int> comb = new List<int>();
                for (int j = 0; j < set.Length; j++)
                {
                    if ((i >> j & 1)==1)
                    {
                        comb.Add(set[j]);
                    }
                }
                if (comb.Sum() != sum) continue;
                Console.WriteLine("{0}={1}", string.Join("+",comb),sum);
                found=true;
            }
            if (!found)
            {
                Console.WriteLine("No matching subsets");
            }
        }
    }

