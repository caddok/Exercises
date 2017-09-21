using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SimpleArraySum
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = SimpleAraySum(ar);
            Console.WriteLine(result);
        }


        static int SimpleAraySum(int[] ar)
        {
            int sum = 0;
            foreach (var number in ar)
            {
                sum += number;
            }

            return sum;
        }
    }

}
