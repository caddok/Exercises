using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SolveMeFirst
    {
        static void Main(string[] args)
        {
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

            int sum = Solve(value1, value2);
            Console.WriteLine(sum);
        }
        
        static  int Solve(int a, int b)
        {
            return a + b;
        }
    }
}
