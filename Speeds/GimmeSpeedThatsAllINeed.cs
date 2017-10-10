using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    class GimmeSpeedThatsAllINeed
    {
        static void Main(string[] args)
        
        {
            var numberOfCars = Convert.ToInt32(Console.ReadLine());
            var speedList = new List<int>();
            for (int i = 0; i < numberOfCars; i++)
            {
                int speed = Convert.ToInt32(Console.ReadLine());
                speedList.Add(speed);
            }
            int legth = 1;
            int sumOfSpeeds = 0;
            int firstCar = speedList.First();
            sumOfSpeeds += firstCar;
            for (int i = 0; i < speedList.Count-1; i++)
            {
               
                if (firstCar<speedList[i+1])
                {
                    sumOfSpeeds += speedList[i+1];
                    legth++;
                }
                else if (firstCar >= speedList[i])
                {
                    firstCar = speedList[i + 1];
                    legth = 1;
                    sumOfSpeeds = 0;
                    sumOfSpeeds += speedList[i + 1];
                }
            }
            Console.WriteLine(sumOfSpeeds);
        }
    }
}
