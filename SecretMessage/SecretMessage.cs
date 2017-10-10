using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecretMessage
{
    class SecretMessage
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int line = 1; ; line++)
            {
                var endOrBegin = Console.ReadLine();
                if (endOrBegin == "end")
                {
                    Console.WriteLine(sb);
                    break;
                }

                var startIndex = Convert.ToInt32(endOrBegin);
                var endIndex = Convert.ToInt32(Console.ReadLine());
                var message = Console.ReadLine();

                int step;
                if (line % 2 != 0)
                {
                    step = 3;
                    GetEveryNthChar(sb, startIndex, endIndex, message, step);
                }
                else
                {
                    step = 4;
                    GetEveryNthChar(sb, startIndex, endIndex, message, step);
                }
            }
        }

        private static void GetEveryNthChar(StringBuilder sb, int startIndex, int endIndex, string message, int step)
        {
            if (startIndex < 0 || endIndex < 0)
            {
                var start = startIndex < 0 ? message.Length + startIndex : startIndex;
                var end = endIndex < 0 ? message.Length + endIndex : endIndex;
                for (int i = start; i <= end; i += step)
                {
                    sb.Append(message[i]);
                }
            }
            else if (startIndex == endIndex) 
            {
                sb.Append(message[startIndex]);
            }
            else
            {
                var realMessage = message.Substring(startIndex, endIndex - startIndex);
                for (int i = 0; i < realMessage.Length; i += step)
                {
                    sb.Append(realMessage[i]);
                }
            }
        }
    }
}
