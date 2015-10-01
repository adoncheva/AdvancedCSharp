using System;
using System.Collections.Generic;
//Problem 6.	Number Calculations
//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.

    class NumberCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter several numbers?");
            char[] separators = { ' ', ',', ';' };
            string[] stringSplitNumbers = Console.ReadLine().Split(separators);
            double[] arrNumber = new double[stringSplitNumbers.Length];
            Console.WriteLine("Enter several decimals?");
            string[] stringSplitDecimal=Console.ReadLine().Split(separators);
            decimal[] arrdNumber = new decimal[stringSplitDecimal.Length];
            bool isDouble,isDecimal;
            for (int i = 0; i < stringSplitNumbers.Length; i++)
            {
                do
                {
                    isDouble = double.TryParse(stringSplitNumbers[i], out arrNumber[i]);
                    if (!isDouble)
                    {
                        Console.WriteLine("Enter a floating-point number:");
                        stringSplitNumbers[i] = Console.ReadLine();
                    }
                } while (!isDouble);
            }
            Console.WriteLine("Min={0:F3}", Min(arrNumber));
            Console.WriteLine("Max={0:F3}", Max(arrNumber));
            Console.WriteLine("Sum={0:F3}", Sum(arrNumber));
            Console.WriteLine("Average={0:F3}", Average(arrNumber));
            for (int i = 0; i < stringSplitDecimal.Length; i++)
            {
                do
                {
                    isDecimal = decimal.TryParse(stringSplitDecimal[i], out arrdNumber[i]);
                    if (!isDecimal)
                    {
                        Console.WriteLine("Enter a decimal number:");
                        stringSplitDecimal[i] = Console.ReadLine();
                    }
                } while (!isDecimal);
            }
            Console.WriteLine("Min={0:C2}",Min(arrdNumber));
            Console.WriteLine("Max={0:C2}", Max(arrdNumber)); 
            Console.WriteLine("Sum={0:C2}", Sum(arrdNumber));
            Console.WriteLine("Average={0:C2}", Average(arrdNumber));
        }
        static public double Min(double[] numbers)
        {
            double min = double.MaxValue;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        static public decimal Min(decimal[] numbers)
        {
            decimal min = decimal.MaxValue;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        static public double Max(double[] numbers)
        {
            double max = double.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        static public decimal Max(decimal[] numbers)
        {
            decimal max = decimal.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        static public double Sum(double[] numbers)
        {
            double sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
               sum += numbers[i];
            }
            return sum;
        }
        static public decimal Sum(decimal[] numbers)
        {
            decimal sum = 0.0m;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static public double Average(double[] numbers)
        {
            double average = (Sum(numbers)) / numbers.Length;
            return average;
        }
        static public decimal Average(decimal[] numbers)
        {
            decimal average = (Sum(numbers)) / numbers.Length;
            return average;
        }
    }

