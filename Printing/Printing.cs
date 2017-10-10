using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing
{
    class Printing
    {
        static void Main(string[] args)
        {
            int students = Convert.ToInt32(Console.ReadLine());
            int sheets = Convert.ToInt32(Console.ReadLine());
            double prizePerRealm = Convert.ToDouble(Console.ReadLine());

            double realms = (students * sheets) / 500;

            Console.WriteLine("{0:F2}",prizePerRealm*realms);

        }
    }
}
