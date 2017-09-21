using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CompareTheTriplets
    {
        static void Main(string[] args)
        {
            string[] tokens_a = Console.ReadLine().Split(' ');
            string[] tokens_b = Console.ReadLine().Split(' ');

            int[] pointsOfAllice = Array.ConvertAll(tokens_a, Int32.Parse);
            int[] pointsOfBob = Array.ConvertAll(tokens_b, Int32.Parse);

            int[] result = CountPoints(pointsOfAllice, pointsOfBob);
            Console.WriteLine(string.Join(" ", result));
        }


        static int[] CountPoints(int[] tokenInts_a, int[] tokenInts_b)
        {
            int allieCount = 0;
            int bobCount = 0;

            for (int i = 0; i < tokenInts_a.Length; i++)
            {


               
                if (tokenInts_a[i] >tokenInts_b[i] )
                {
                    allieCount++;
                }
                else if(tokenInts_a[i] < tokenInts_b[i])
                {
                    bobCount++;
                }

            }

            return new[] { allieCount, bobCount };
        }

    }
}
