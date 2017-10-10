using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmTriangle
{
    class VmTriangle
    {
        private static int Triangle(int rows)
        {
            if (rows == 0)
            {
                return rows;
            }
            return rows + Triangle(rows - 1);
        }

        static void Main(string[] args)
        {
            int rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Triangle(rows));
        }
        
    }
}
