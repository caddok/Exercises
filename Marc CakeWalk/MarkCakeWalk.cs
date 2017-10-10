using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_CakeWalk
{
    class MarkCakeWalk
    {
        static void Main(string[] args)
        {
            int numberOfCupcakes = Convert.ToInt32(Console.ReadLine());
            string[] caloriesTemp = Console.ReadLine().Split(' ');
            int[] calories = Array.ConvertAll(caloriesTemp, int.Parse);
            Array.Sort(calories);
            Array.Reverse(calories);
           
            long milesToWalk = 0;
            int power = 2;
            for (int i = 0; i < calories.Length; i++)
            {
                double cal = calories[i];
                milesToWalk = (long) (milesToWalk + cal * (Math.Pow(power, i)));
            }
            Console.WriteLine(milesToWalk);
        }
    }
}
