using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer1
    {
        public int buyChance;
        public int buyPrice;
        public int weatherDemand;

        public Customer1(Recipe recipe, Weather weather)
        {
           /* GetBuyChance(recipe);*/
            GetWeatherDemand(weather);
        }
        /*public int GetBuyChance(Recipe recipe)
        {
            if (recipe.lemonadePrice <
        }*/

        public int GetWeatherDemand(Weather weather)
        {
            if (weather.temperature == 1 && weather.condition == "cloudy")
            {
                buyPrice = 
        
            }
        }
        
    }
}
