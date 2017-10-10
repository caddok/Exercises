using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalFromSpace
{
    class SignalForSpace
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder result = new StringBuilder(message);

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    result.Remove(i - 1, 1);
                    i = 0;
                }
            }
            
            Console.WriteLine(result);
            
        }
    }
}
