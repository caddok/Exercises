using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalNumbers
{
    class MagicalNumbers
    {
        static void Main(string[] args)
        {
            string magicNumber = Console.ReadLine();

            int[] intArray = new int[magicNumber.Length];

            for (int i = 0; i < magicNumber.Length; i++)
            {
                intArray[i] = int.Parse(magicNumber);
            }
            int result = 0;

            if (intArray[1]/2==0)
            {
                result = intArray[0] + intArray[1] * intArray[2];
            }
            else
            {
                result = intArray[0] * intArray[1] / intArray[3];
            }

            Console.WriteLine(result);

        }
    }
}
