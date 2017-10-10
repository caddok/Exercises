using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// sb: 2

//12
//23f
//34s
//45

namespace MergingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfNumbers = Convert.ToInt32(Console.ReadLine());

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            var sb = new StringBuilder();
            var sums = new List<int>();
            
            sums.Add(firstNumber + secondNumber);
            sb.Append(firstNumber % 10);

            for (int i = 0; i < linesOfNumbers - 2; i++)
            {
                firstNumber = secondNumber;
                secondNumber = Convert.ToInt32(Console.ReadLine());

                sums.Add(firstNumber + secondNumber);

                sb.Append(firstNumber / 10 + " " + firstNumber % 10);
            }

            sb.Append(secondNumber / 10);

            Console.WriteLine(sb.ToString());
            foreach (var num in sums)
            {
                Console.Write(num + " ");
            }
            Console.Write("\n");
        }
    }
}
