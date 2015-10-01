using System;
using System.Collections.Generic;
using System.Linq;
//Problem 3.	Categorize Numbers and Find Min / Max / Average
//Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).


namespace CategoriseNumbersMinMaxSumAverage
{
    class CategoriseNumbersMinMaxSumAverage
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


            double[][]jaggedIntDouble=new double[2][];
            int integers=0, doubles=0;
            for (int i = 0; i < splitNumber.Length; i++)
            {
                if (splitNumber[i] % (int)splitNumber[i] == 0)
                {
                    integers++;
                }
                else
                {
                    doubles++;
                }

            }
            jaggedIntDouble[0] = new double[integers];
            jaggedIntDouble[1] = new double[doubles];
            int k = 0,l=0;
            foreach (var number in splitNumber)
            {
                  if (number % (int)number == 0)
                    {
                       
                        jaggedIntDouble[0][k] = number;
                        k++;
                        if (k == integers) break;
                        
                    }
                               
            }
            foreach (var number in splitNumber)
            {
                if (number % (int)number != 0)
                    {
                       
                        jaggedIntDouble[1][l] = number;
                        l++;
                        if (l == doubles) break;
                        
                    } 
            }
           
             Console.Write("[{0}]->min: {1}, max: {2}, sum: {3}, avg: {4:F2}",string.Join(", ",jaggedIntDouble[0]),jaggedIntDouble[0].Min(),jaggedIntDouble[0].Max(),jaggedIntDouble[0].Sum(),jaggedIntDouble[0].Average());
            Console.WriteLine();
            Console.Write("[{0}]->min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", jaggedIntDouble[1]), jaggedIntDouble[1].Min(), jaggedIntDouble[1].Max(), jaggedIntDouble[1].Sum(), jaggedIntDouble[1].Average());
            Console.WriteLine();
            
           
          
        }
    }
}
