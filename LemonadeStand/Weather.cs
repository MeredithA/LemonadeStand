using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        // member variables (HAS A)
        public int actualWeatherTemperture;
        public string actualWeatherCondition;
        public List<string> possibleWeatherConditions;
        public List<int> possibleWeatherTemperature;
        public Random random;

        // constructor (SPAWNER)
        public Weather()
        {
            possibleWeatherConditions = new List<string>() { "sunny", "partly cloudy", "rain", "cloudy", "hazy" };
            possibleWeatherTemperature = new List<int>() { 87, 75, 66, 50, 67, 91 };
            random = new Random();
        }

        // member methods (CAN DO)
        public string ActualWeatherCondition()
        {
            int actualWeatherCondition;

            actualWeatherCondition = random.Next(0, possibleWeatherConditions.Count);
            return possibleWeatherConditions[actualWeatherCondition];

        }

        public int ActualWeatherTemperture()
        {
            int actualWeatherTemperture;

            actualWeatherTemperture = random.Next(0, possibleWeatherTemperature.Count);
            return possibleWeatherTemperature[actualWeatherTemperture];
        }
    }
}
