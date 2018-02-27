using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables (HAS A)
        LemonadeRecipe recipe;
        public Weather todaysForcast;
        public Weather todaysTempurature;
        public Random random;
        public double pricePerCup;

        private Customer customer;
            // public int dailyAmountOfCustomers = 70;

        private List<string> availableItems;
        public string purchaseInventory;

        // constructor (SPAWNER)
        public Day()
        {
            random = new Random();
            todaysForcast = new Weather();
            todaysTempurature = new Weather();
            recipe = new LemonadeRecipe();
        }

        // member methods (CAN DO)
        public void ActualWeatherCondition()
        {
            todaysForcast.ActualWeatherCondition();
        }

        public void ActualWeatherTemperature()
        {
            todaysTempurature.ActualWeatherTemperature();
        }

        public double PriceOfCup()
        {
            Console.WriteLine("Set your lemonade price for the day. Remember the weather should be factored in.");
            {
                double pricePerCup = double.Parse(Console.ReadLine());
                this.pricePerCup = pricePerCup;
                return this.pricePerCup;
            }
        }
    }
}
