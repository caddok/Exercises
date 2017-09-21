using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0;i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int firstDiagonalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               firstDiagonalSum += arr[i][i];
                
            }
            int secondDiagonalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                secondDiagonalSum += arr[i][n - i - 1];
            }
           
            Console.WriteLine(Math.Abs(firstDiagonalSum-secondDiagonalSum));

        }
    }
}
