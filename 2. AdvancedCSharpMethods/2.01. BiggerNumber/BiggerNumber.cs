using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01.BiggerNumber
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool isInt;
            do
            {
                Console.Write("Enter first number: ");
                isInt = int.TryParse(Console.ReadLine(), out firstNumber);
                if (!isInt)
                {
                    Console.Write("Floating-point number or string found. Please enter an integer: ");
                } 
            } while (!isInt);
            do
            {
                Console.Write("Enter second number: ");
                isInt = int.TryParse(Console.ReadLine(), out secondNumber);
                if (!isInt)
                {
                    Console.Write("Floating-point number or string found. Please enter an integer: ");
                }
                
            } while (!isInt);
            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }
        static public int GetMax(int a, int b)
        {
            int max=int.MinValue;
            if (a >= b)
            {
                max = a;
            }
            else if(a<b)
            {
                max = b;
            }
            return max;
        }
    }
}
