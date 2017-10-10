using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();
            for ( ; ; )
            {
                var input = Console.ReadLine().Split(' ');
                if (input.Contains("end"))
                {
                    break;
                }
                Console.ReadLine();

                if (input[0] == "set")
                {
                    result.Clear();
                    result.Append(input[1]);
                    Console.WriteLine(result.ToString());
                }
                else if (input[0] == "reverse")
                {
                    result = new StringBuilder(new string(result.ToString().ToCharArray().Reverse().ToArray()));
                    Console.WriteLine(result.ToString());
                }
                else if (input[0] == "front-remove")
                {
                    result = result.Remove(0, 1);
                    Console.WriteLine(result.ToString());
                }

                else if (input[0] == "front-add")
                {

                    result = result.Insert(0, input[1]);
                    Console.WriteLine(result.ToString());

                }
                else if (input[0] == "back-add")
                {
                    result.Append(input[1]);
                    Console.WriteLine(result.ToString());
                }

            }
        }
    }
}
