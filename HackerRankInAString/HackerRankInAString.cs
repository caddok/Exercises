using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankInAString
{
    class HackerRankInAString
    {
        static void Main(string[] args)
        {
            int numberOfQueries = Convert.ToInt32(Console.ReadLine());
            const string hackerrank = "hackerrank";

            for (int i = 0; i < numberOfQueries; i++)
            {
                string currentString = Console.ReadLine();
                Regex hack = new Regex(@"h\w*?a\w*?c\w*?k\w*?e\w*?r\w*?r\w*?a\w*?n\w*?k", RegexOptions.Compiled);

                if (hack.IsMatch(currentString))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                //    if (hackerrank.Length > currentString.Length)
                //    {
                //        Console.WriteLine("NO");
                //        continue;
                //    }

                //    bool containsWord = false;
                //    for (var j = 0; j < currentString.Length - hackerrank.Length; j++)
                //    {
                //        string stringToCompare = currentString.Substring(i, hackerrank.Length);
                //        if (hackerrank == stringToCompare)
                //        {
                //            containsWord = true;
                //            break;
                //        }
                //    }
                //    if (containsWord)
                //    {
                //        Console.WriteLine("YES");
                //    }
                //    else
                //    {
                //        Console.WriteLine("NO");
                //    }
                //}
            }
        }
    }
}
