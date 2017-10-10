using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNumbers
{
    class BalancedNumbers
    {
        static void Main(string[] args)
        {
            
            var result = 0;

            for (;;)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if ((input/100)+(input%10)==(input/10)%10)
                {
                    result += input;
                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
