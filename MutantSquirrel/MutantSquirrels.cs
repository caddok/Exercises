using System;
using System.Data.SqlTypes;

namespace MutantSquirrel
{
    class MutantSquirrels
    {
        static void Main(string[] args)
        {
            int tree = Convert.ToInt32(Console.ReadLine());
            int branches = Convert.ToInt32(Console.ReadLine());
            int squirrelsPerBranch = Convert.ToInt32(Console.ReadLine());
            int avgTails = Convert.ToInt32(Console.ReadLine());

            float result = tree * branches * squirrelsPerBranch * avgTails;

            if (result%2!=0)
            {
                result /= 7;
            }
            else
            {
                result *= 376439;
            }

            Console.WriteLine("{0:F3}",result);
        }
    }
}
