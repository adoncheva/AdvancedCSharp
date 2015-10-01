using System;
using System.Collections.Generic;
using System.Linq;
//Problem 7.	* Sorted Subset Sums
//Modify the program you wrote for the previous problem to print the results in the following way: each line should contain the operands (numbers that form the desired sum) in ascending order; the lines containing fewer operands should be printed before those with more operands; when two lines have the same number of operands, the one containing the smallest operand should be printed first. If two or more lines contain the same number of operands and have the same smallest operand, the order of printing is not important.




    class SortedSubsetSums
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
           isSubsetSorted(splitNumber, intNum);
        }
         public static void isSubsetSorted(int[] set, int sum)
        {
            bool found=false;
            int combinations = 1 << set.Length;
            List<List<int>>SortedSubsets=new List<List<int>>();
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
                SortedSubsets.Add(comb);
                found=true;
            }
            if (!found)
            {
                Console.WriteLine("No matching subsets");
            }
           if (SortedSubsets.Count!=0)
            
		        SortedSubsets.ForEach(list=>list.Sort());
               SortedSubsets=SortedSubsets.OrderBy(p=>p.Count).ThenBy(p1=>p1.First()).ToList();
               SortedSubsets.ForEach(list=>Console.WriteLine("{0}={1}",string.Join("+",list),sum));
	        }
        }
    
       

