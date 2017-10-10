using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckBalance
{
    class LuckBalance
    {
        static void Main(string[] args)
        {
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrTemp, int.Parse);
            int contests = arr[0];
            int loseableContests = arr[1];
            var competitions = new List<Competition>();
            for (int i = 0; i < contests; i++)
            { 
                string[] lines = Console.ReadLine().Split(' ');
                int[] arrOfLines = Array.ConvertAll(lines, int.Parse);
                int luck = arrOfLines[0];
                int importance = arrOfLines[1];

                var comp = new Competition(luck, importance);
                competitions.Add(comp);

            }
            competitions.Sort();
            competitions.Reverse();
            int luckScore = 0;
            int lostContests = 0;
            foreach (var competition in competitions)
            {
                if (competition.Importance == 0)
                {
                    luckScore += competition.LuckPoints;
                }
                else if (lostContests<loseableContests)
                {
                    luckScore += competition.LuckPoints;
                    lostContests++;
                }
                else
                {
                    luckScore -= competition.LuckPoints;
                }
            }
            Console.WriteLine(luckScore);
        }
    }

    class Competition : IComparable<Competition>
    {
        public int LuckPoints { get; }
        public int Importance { get; }

        public Competition(int luckPoints, int importance)
        {
            LuckPoints = luckPoints;
            Importance = importance;
        }
        public int CompareTo(Competition obj)
        {
            return this.LuckPoints - obj.LuckPoints;

            //if (this.LuckPoints > obj.LuckPoints)
            //{
            //    return 1;
            //}
            //if (this.LuckPoints < obj.LuckPoints)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}
