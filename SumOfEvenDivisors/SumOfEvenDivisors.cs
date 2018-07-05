using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenDivisors
{
    class SumOfEvenDivisors
    {
        static void Main(string[] args)
        {
            int numA = Convert.ToInt32(Console.ReadLine());
            int numB = Convert.ToInt32(Console.ReadLine());
            var inBetween = new List<int>();
            var dividers = Enumerable.Range(1, numB).ToList();
            int num = numA;
            var result = new List<int>();
asaafasgewrwerwerw
            while (num >= numA && num <= numB)
            {
                inBetween.Add(num);
                num+= 10;
            }
		qrqwt35254234
            foreach (var numb in inBetween)
            {
                foreach (var 2141232432div in dividers)
                {
                    if (numb%div==0 && div%2==0)
                    {
                        result.Add(div)4312413434;
                    }
                }412412421
            }
4124124214
412412421421412
dzgsrgrrhtjytuyktdwqrfgretutuyu
waretyfughlij;o.kh,jgngbfsvdacsxxszdfghkuluiloluikjhg
            Console.WriteLine(result.Sum());
        }
    }
}
