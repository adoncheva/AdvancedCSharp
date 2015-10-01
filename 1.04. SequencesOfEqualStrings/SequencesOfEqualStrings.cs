using System;
using System.Collections.Generic;
using System.Linq;
//Problem 4.	Sequences of Equal Strings
//Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space. 


    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter several strings?");
            char[] separators = { ' ', ',', ';' };
            string[] strings = Console.ReadLine().Split(separators).ToArray();
            string[] stringsDistinct = strings.Distinct().ToArray();
            int[] count = new int[strings.Distinct().ToArray().Length];
            string[][] jaggedString = new string[count.Length][];
            int cnt;

            for (int i = 0; i < count.Length; i++)
            {
                cnt = 0;
                for (int j = 0; j < strings.Length; j++)
                {
                    if (stringsDistinct[i] == strings[j])
                    {
                        cnt++;
                    }

                }

                count[i] = cnt;
                jaggedString[i] = new string[cnt];
            }


            for (int i = 0; i < jaggedString.Length; i++)
            {
                for (int j = 0; j < jaggedString[i].Length; j++)
                {

                    {
                        jaggedString[i][j] = stringsDistinct[i];
                    }

                }
            }

           
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(string.Join(",", jaggedString[i]));
            }


        }
    }

