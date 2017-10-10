using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MagicalNumbers
{
    class MagicalNumbers
    {
        static void Main(string[] args)
        {
            int magicInput = int.Parse(Console.ReadLine());
            List<int> magicHappens = new List<int>();
            while (magicInput>0)
            {
                magicHappens.Add(magicInput%10);
                magicInput /= 10;
            }
            magicHappens.Reverse();
            magicHappens.ToArray();
            double result = 0;
            if (magicHappens[1]%2!=0)
            {
               result = (magicHappens[0] * magicHappens[1]) / magicHappens[2];
            }
            else
            {
                result = (magicHappens[0] + magicHappens[1]) * magicHappens[2];
            }
            Console.WriteLine("{0:F2}",result);
        }
        
    }
}
