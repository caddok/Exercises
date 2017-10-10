using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PapperCutter
{
    class PapperCutter
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int remainder = 0;

            while (number/2==0)
            {
                counter++;

                if (number%2==1)
                {
                    remainder += 1;
                    break;
                }
            }


        }

        


    }
}
