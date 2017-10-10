using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class BirthdayCakeCandles
    {
        static void Main(string[] args)
        {
            Console.ReadLine(); // reading unused size variable
            string[] arr_temp = Console.ReadLine().Split();
            int[] candlesHight = Array.ConvertAll(arr_temp, int.Parse);

            int candlesMaxHeight = candlesHight.Max();

            int candlesCount = candlesHight.Count(candle => candle == candlesMaxHeight);
            Console.WriteLine(candlesCount);

        }
    }
}
