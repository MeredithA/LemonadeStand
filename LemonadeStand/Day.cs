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
        public LemonadeRecipe lemonadeRecipe;
        public Weather weather;
        public double pricePerCup;

      //  private Customer customer;
            // public int dailyAmountOfCustomers = 70;

        // constructor (SPAWNER)
        public Day()
        {
            Weather weather = new Weather();
            LemonadeRecipe lemonadeRecipe = new LemonadeRecipe();
        }

        //member methods (CAN DO)

        public void ActualWeatherCondition()
        {
            weather.ActualWeatherCondition();
        }

        public void ActualWeatherTemperture()
        {
            weather.ActualWeatherTemperture();
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
