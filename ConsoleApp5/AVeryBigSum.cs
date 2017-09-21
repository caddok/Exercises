using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class AVeryBigSum
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = CalculatingBigNumbers(n, ar);
            Console.WriteLine(result);
        }

        static long CalculatingBigNumbers(int n, long[] ar)
        {
            long sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }
            return sum;
        }
    }
}
