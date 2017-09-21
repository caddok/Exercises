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
            int first = 0;
            int second = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                int number2 = numbers[i + 1];


                if (Math.Abs(number - number2)<numbers.Min())
                {
                    second = first;
                    first = number;
                }

            }

            

            Console.WriteLine(Math.Abs(first - second));
        }
    }
}
