using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MythicNumbers
{
    class MythicNumbers
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var mythicDigits = new List<float>();
            while (number>0)
            {
                mythicDigits.Add(number%10);
                number /= 10;
            }
            mythicDigits.Reverse();
            mythicDigits.ToArray();
            double result = 0;

            if (mythicDigits[2]==0)
            {
                result = mythicDigits[0] * mythicDigits[1];
            }else if (mythicDigits[2]<=5)
            {
                result = (mythicDigits[0] * mythicDigits[1]) / mythicDigits[2];
            }
            else if(mythicDigits[2]>5)
            {
                result = (mythicDigits[0] + mythicDigits[1]) * mythicDigits[2];
            }
            Console.WriteLine("{0:F2}",result);
        }
    }
}
