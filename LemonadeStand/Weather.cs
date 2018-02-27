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
        public int todaysWeatherTemperature;
        public List<string> weatherConditionPossibilities;
        public List<int> weatherTempuraturePossibilities;
        public Random random;

        // constructor (SPAWNER)
        public Weather()
        {
            weatherConditionPossibilities = new List<string>() { "sunny", "partly cloudy", "rain", "cloudy", "hazy" };
            weatherTempuraturePossibilities = new List<int>() { 87, 75, 66, 50, 67, 91 };
            random = new Random();
        }

        // member methods (CAN DO)
        public int actualTempurature()
        {
            int todaysTempurature;

            todaysTempurature = random.Next(0, weatherConditionPossibilities.Count);
            return weatherTempuraturePossibilities[todaysTempurature];
        }

        public string ActualWeatherCondition()
        {
            int todaysForcast;

            todaysForcast = random.Next(0, weatherConditionPossibilities.Count);
            return weatherConditionPossibilities[todaysForcast];
        }

        public int ActualWeatherTemperature()
        {
            int todaysTempuratureIndexValue;

            todaysTempuratureIndexValue = random.Next(0, weatherTempuraturePossibilities.Count);
            return weatherTempuraturePossibilities[todaysTempuratureIndexValue];
        }

        public string ActualWeatherForecast()
        {
            int actualForcastIndexValue;

            actualForcastIndexValue = random.Next(0, weatherConditionPossibilities.Count);
            return weatherConditionPossibilities[actualForcastIndexValue];

        }
    }
}
