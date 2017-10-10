using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// moga li da sortiram array po absoliutna stoinost ???
namespace AbsoluteMinDifference
{
    class AbsoluteMinDifference
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Sort(numbers);
            int minDiff = numbers[1] - numbers[0];
           
            for (int i = 2; i != numbers.Length; i++)
            {
                minDiff = Math.Min(minDiff, numbers[i] - numbers[i - 1]);
            }
            
            Console.WriteLine(Math.Abs(minDiff));
        }
    }
}
