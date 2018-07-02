using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Console");
            for (int ii=10; ii<100;)
            {
                Console.WriteLine("ii:{0} = {1}",ii.ToString(), 
                    RomanNumerals.Operations.ConvertTensToRoman(ii++));
            }





            Console.ReadLine();
        }
    }
}
