using System;
using System.Collections.Generic;
using System.Linq;
//Generic Array Sort
//Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort (your own implementation). You may re-use your code from a previous homework and modify it. 
//Use a generic method (read in Internet about generic methods in C#). Make sure that what you're trying to sort can be sorted – your method should work with numbers, strings, dates, etc., but not necessarily with custom classes like Student.

    class GenericArraySort
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 3, 4, 5, 1, 0, 5 };
            SortArray<int>(number);
            string[] strings = { "zaz", "cba", "baa", "azis" };
            SortArray<string>(ref strings);
            DateTime[] dates=
            {
                new DateTime(2002,3,1),
                new DateTime(2015, 5, 6),
                new DateTime(2014, 1, 1),
            };
            SortArray<DateTime>(dates);

        }
        static public void SortArray<T>(T[] numbers) where T: struct, System.IComparable<T>
        {
            T temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i].CompareTo(numbers[j]) > 0)
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
        }
         static public void SortArray<T>(ref T[] numbers) where T:class, System.IComparable<T>
        {
            T temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i].CompareTo(numbers[j]) > 0)
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
        }
    }

