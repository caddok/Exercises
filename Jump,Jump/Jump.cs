using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Jump
{
    class Jump
    {
        static void Main(string[] args)
        {
            var danceDirection = Console.ReadLine();
            int position = 0;
            int directon = 0;

            for (int i = 0; i < danceDirection.Length; i+=position)
            {
                directon = danceDirection[i];

                if (char.IsDigit((char)directon)&& directon%2==0)
                {
                    position += directon;
                    i = 0;
                }else if (char.IsDigit((char)directon)&& directon%2!=0)
                {
                    position -= directon;
                    i = 0;
                }
                else if(directon=='^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}",position);
                    break;
                }
                else if (position == 0)
                {
                    Console.WriteLine("Too drunk to go on after {0}",position);
                    break;
                }
                else if (position > danceDirection.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}",position);
                    break;
                }
            }

        }
    }
}
