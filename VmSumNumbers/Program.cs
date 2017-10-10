using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmSumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    sum += c;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
