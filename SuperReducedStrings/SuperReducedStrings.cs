using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedStrings
{
    class SuperReducedStrings
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder result = new StringBuilder(s);

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    result.Remove(i - 1, 2);
                    i = 0;
                }
            }
            if (result.Length == 0)
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
