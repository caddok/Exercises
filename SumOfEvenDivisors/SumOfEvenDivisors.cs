using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenDivisors
{
    class SumOfEvenDivisors
    {
        static void Main(string[] args)
        {
            int numA = Convert.ToInt32(Console.ReadLine());
            int numB = Convert.ToInt32(Console.ReadLine());
            var inBetween = new List<int>();
            var dividers = Enumerable.Range(1, numB).ToList();
            int num = numA;
            var result = new List<int>();
            while (num >= numA && num <= numB)
            {
                inBetween.Add(num);
                num++;
            }

            foreach (var numb in inBetween)
            {
                foreach (var div in dividers)
                {
                    if (numb%div==0 && div%2==0)
                    {
                        result.Add(div);
                    }
                }
            }

            Console.WriteLine(result.Sum());
        }
    }
}
