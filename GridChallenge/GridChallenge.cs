using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class GridChallenge
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool isSorted = true;
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                string inputTemp = Console.ReadLine();

                char[][] matrix =new char[i][];
                for (int j = 0; j < i; matrix[j++] = Console.ReadLine()?.ToCharArray()) ;

                for (int j = 0; j < i; j++)
                {
                    Array.Sort(matrix);
                }

                isSorted = true;
                for (int j = 0; j < i; j++)
                {
                    for (int k = 1; 1 < i; k++)
                    {
                        if (matrix[k][j]<matrix[k-1][j])
                        {
                            j = i;
                            isSorted = false;
                            break;
                        }
                    }
                }
                Console.WriteLine(isSorted);
            }
            Console.WriteLine(isSorted?"Yes":"NO");
        }
    }
}
