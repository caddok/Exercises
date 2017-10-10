using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legs
{
    class Legs
    {
        

        static void Main(string[] args)
        {
            int legs = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int combos = 0;
            while (true)
            {
                sum += 2;
                if (sum >= legs)
                {
                    if (sum == legs)
                    {
                        combos++;
                    }
                    break;
                }
                while (true)
                {
                    sum += 5;
                    if (sum >= legs)
                    {
                        if (sum == legs)
                        {
                            combos++;
                        }
                        break;
                    }
                    while (true)
                    {
                        sum += 7;
                        if (sum >= legs)
                        {
                            if (sum == legs)
                            {
                                combos++;
                            }
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(combos);
        }


    }
}
