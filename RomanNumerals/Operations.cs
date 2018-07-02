using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Operations
    {
        /**
         * Function that will take number and convert it to roman numewrals
         **/
        public static string ConvertUnitsToRoman(int numToConvert)
        {
            string result = "";
            int ones = numToConvert % 10;
            string[] roman = { "", "I", "II", "III", "IV", "V", "VI", "VII", "IIX", "IX", };
            result = roman[ones];
            return result;
        }
        public static string ConvertTensToRoman(int numToConvert)
        {
            string result = "";
            int tens = int.Parse(digit(2, numToConvert)); //Here's the problem...
            string[] roman = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
            result = roman[tens];
            return result;
        }

        public static string digit(int position, int number)
        {
            string result = number.ToString().Substring(number.ToString().Length - position,1);
            return result;
        }
    }
}
