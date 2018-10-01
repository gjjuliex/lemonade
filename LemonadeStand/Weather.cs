using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string temperature;
        public string condition;


        public Weather()
        {


        }


        public int GetTemperature(Random rand)
        {
            int temperature = rand.Next(1, 4);
            switch (temperature)
            {
                case 1:
                    this.temperature = rand.Next(50, 60);
                    break;
                case 2:
                    this.temperature = rand.Next(61, 70);
                    break;
                case 3:
                    this.temperature = rand.Next(71, 95);
                    break;
                case 4:
                    this.temperature = rand.Next(96, 111);           
            }
            return temperature;
        }

        public int GetOvercast(Random rand)
        {
            int condition = rand.Next(1, 4);
            switch (condition)
            {
                case 1:
                    this.condition = "cloudy";
                    break;
                case 2:
                    this.condition = "rainy";
                    break;
                case 3:
                    this.condition = "sunny";
                    break;
                case 4:
                    this.condition = "windy";
                    break;
            }
            return condition;
        }

        public void DisplayTodaysWeather()
        {
            Console.WriteLine("Today's temperature is {0} and it will be {1)!!", temperature, condition);
        }

    }

 }

