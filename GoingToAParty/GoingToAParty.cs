using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToAParty
{
    class GoingToAParty
    {
        static void Main(string[] args)
        {
            var partyDirections = Console.ReadLine();
            var position = 0;

            int direction;
            for (var index = 0; index < partyDirections.Length;index+=position)
            {
                direction = partyDirections[index];
                if (char.IsLower((char) direction))
                {
                    position += direction - 96;
                    index = 0;
                }
                else if (char.IsUpper((char) direction))
                {
                    position -= direction - 64;
                    index = 0;
                }
                else if (direction == '^')
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", position);
                    break;
                }

                if (position>partyDirections.Length || position <0)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", position);
                }
            }
            
        }
    }
}
