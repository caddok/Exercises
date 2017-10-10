using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class MarsExploration
    {
        static void Main(string[] args)
        {
            //string signal = Console.ReadLine(); - za celi dumi 
            //int brokenSignals = 0;

            //const int chunkSize = 3;
            //bool isValidMessage = true;
            //for (var i = 0; i < signal.Length; i++)
            //{
            //    if (i % chunkSize == 0)
            //        isValidMessage = true;

            //    if (signal[i] != "SOS"[i % chunkSize])
            //    {
            //        isValidMessage = false;
            //    }

            //    if (i % chunkSize == chunkSize - 1 && !isValidMessage)
            //        brokenSignals++;
            //}
            //Console.WriteLine(brokenSignals);

            string signal = Console.ReadLine(); // za bukvi
            int differentChars = 0;

            const int chunkSize = 3;
            for (var i = 0; i < signal.Length; i++)
            {
                if (signal[i] != "SOS"[i % chunkSize])
                {
                    differentChars++;
                }

            }
            Console.WriteLine(differentChars);

        }
    }
}
