using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashingNumbers
{
    class SquashingNumbers
    {
        static void Main(string[] args)
        {
            int linesOfNumbers = Convert.ToInt32(Console.ReadLine());

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            var sb = new StringBuilder();
            var sNewNums = new StringBuilder();

            GetMiddleNumber(firstNumber, secondNumber, sNewNums);

            sb.Append(firstNumber % 10);

            for (int i = 0; i < linesOfNumbers - 2; i++)
            {
                firstNumber = secondNumber;
                secondNumber = Convert.ToInt32(Console.ReadLine());

                GetMiddleNumber(firstNumber,secondNumber,sNewNums);

                sb.Append(firstNumber / 10 + " " + firstNumber % 10);
            }

            sb.Append(secondNumber / 10);

            Console.WriteLine(sb.ToString());
            Console.WriteLine(sNewNums.ToString());
        }

        private static void GetMiddleNumber(int firstNumber, int secondNumber, StringBuilder sNewNums)
        {
            int middleNumber = (firstNumber % 10) + (secondNumber / 10);
            sNewNums.Append(firstNumber / 10);
            sNewNums.Append(middleNumber);
            sNewNums.Append(secondNumber % 10 + " ");
        }
    }
}
