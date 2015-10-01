using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._02.LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            long number;
            bool isLong;
            do
            {
                Console.Write("Enter an integer: ");
                isLong = long.TryParse(Console.ReadLine(), out number);
                if (!isLong)
                {
                    Console.Write("String or a floating point found. Enter an integer, please: ");
                }
            } while (!isLong);
            Console.WriteLine(GetLastDigitAsWord(number));
        }
         static public string GetLastDigitAsWord(long number)
    
        { byte digit=(byte)(number%10);
        string digitWord="";
        switch (digit)
        {
            case 0:
                digitWord = "zero ";
                break;
            case 1:
                digitWord = "one ";
                break;
            case 2:
                digitWord = "two ";
                break;
            case 3:
                digitWord = "three ";
                break;
            case 4:
                digitWord = "four ";
                break;
            case 5:
                digitWord = "five ";
                break;
            case 6:
                digitWord = "six ";
                break;
            case 7:
                digitWord = "seven ";
                break;
            case 8:
                digitWord = "eight ";
                break;
            case 9:
                digitWord = "nine ";
                break;
        }
        return digitWord;
        }
    }
}
