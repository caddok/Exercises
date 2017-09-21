using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    internal class MinMaxSum
    {
        private static void Main(string[] args)
        {
           
            string[] arrTemp = Console.ReadLine().Split();
            long[] arr = Array.ConvertAll(arrTemp, long.Parse);

            Console.WriteLine($"{GetMinSum(arr)} {GetMaxSum(arr)}");
        }

        private static long GetMaxSum(long[] numbers)
        {
            return numbers.Sum() - numbers.Max();
        }

        private static long GetMinSum(long[] numbers)
        {
            return numbers.Sum() - numbers.Max();
        }
    }
}
