using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Days
    {
        public Weather weather;
        public int day;


        public Day()
        {
            day = 1;
            weather = new Weather();
        }

        public void Weather(Random rand)
        {
            weather.GetTemperature(rand);
            weather.GetOvercast(rand);
            weather.DisplayTodaysWeather();
        }

        public void DisplayDay()
        {
            Console.WriteLine("Day {1}", day);
        }


    }   

}


