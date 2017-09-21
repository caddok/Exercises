using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class PlusMinus
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arrOfNumbers = Array.ConvertAll(arr_temp, Int32.Parse);

            float plusCount = 0;
            float minusCount = 0;
            float zeroCount = 0;

            foreach (var number in arrOfNumbers)
            {
                if (number < 0)
                {
                    minusCount++;
                }
                else if (number > 0)
                {
                    plusCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine("{0}", plusCount / arrOfNumbers.Length);
            Console.WriteLine("{0}", minusCount / arrOfNumbers.Length);
            Console.WriteLine("{0}", zeroCount / arrOfNumbers.Length);
        }
    }
}
