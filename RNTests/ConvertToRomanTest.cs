using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RNTests
{
    [TestClass]
    public class ConvertToRomanTest
    {
        [TestInitialize]
        public void Init()
        {

        }
 
        [TestMethod]
        public void TestOnes()
        {
            int[] valArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] roman = { "I", "II", "III", "IV", "V", "VI", "VII", "IIX", "IX", };
            foreach(int ii in valArray)
            {
                string ans = Operations.ConvertUnitsToRoman(ii);
                Assert.AreEqual(ans, roman[ii-1]);
            }
        }
        [TestMethod]
        public void TestTens()
        {
            int[] valArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            string[] roman = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
            for (int ii=0;ii< valArray.Length;ii++)
            {
                string ans = Operations.ConvertTensToRoman(valArray[ii]);
                Assert.AreEqual(ans, roman[ii]);
            }
        }

    }
}
