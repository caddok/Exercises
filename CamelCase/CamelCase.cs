using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class CamelCase
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int wordsCount = s.Count(char.IsUpper);

            wordsCount += 1;
            Console.WriteLine(wordsCount);
        }
    }
}
