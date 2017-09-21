using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class TimeConversion
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            var converTime = Convert.ToDateTime(time);
            string result = converTime.ToString("HH:mm:ss  ", CultureInfo.CurrentCulture);
            Console.WriteLine(result);
        }
    }
}
