using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MazeRunner
    {
        static void Main(string[] args)
        {
            int numberCount = Convert.ToInt32(Console.ReadLine());
            int currentNumber = 0;

            for (int i = 0; i < numberCount; i++)
            {
                currentNumber = Convert.ToInt32(Console.ReadLine());
                var result = SeparatedNumbers(currentNumber);
                int oddNumbers = 0;
                int evenNumbers = 0;
                foreach (var digit in result)
                {
                    if (digit % 2 == 0)
                    {
                        evenNumbers += digit; 
                    }
                    else
                    {
                        oddNumbers += digit;
                    }
                }
                if (evenNumbers > oddNumbers)
                {
                    Console.WriteLine("left");
                }
                else if (oddNumbers > evenNumbers)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("straight");
                }

            }

        }

        static int[] SeparatedNumbers(int number)
        {
            var digits = new List<int>();

            while (number > 0)
            {
                digits.Add(number % 10);
                number = number / 10;
            }
            digits.Reverse();
            return digits.ToArray();
        }
    }
}

