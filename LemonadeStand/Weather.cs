using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // member variables (HAS A)
        public string actualWeathercondition;
        public int actualTemperature;
        public List<string> weatherConditionPossibilities;
        public List<int> weatherTempuraturePossibilities;
        public Random random;

        // constructor (SPAWNER)
        public Weather()
        {
            weatherConditionPossibilities = new List<string>() { "sunny", "overcast", "rain", "cloudy", "hazy" };
            weatherTempuraturePossibilities = new List<int>() { 87, 75, 66, 50, 67, 91 };
            random = new Random();
        }

        // member methods (CAN DO)
        public int getActualTempurature()
        {
            int actualTemperature;

            actualTemperature = random.Next(0, weatherConditionPossibilities.Count);
            return weatherTempuraturePossibilities[actualTemperature];
        }

        public string GetActualyWeatherCondition()
        {
            int actualWeatherConditions;

            actualWeatherConditions = random.Next(0, weatherConditionPossibilities.Count);
            return weatherConditionPossibilities[actualWeatherConditions];
        }
    }
}
