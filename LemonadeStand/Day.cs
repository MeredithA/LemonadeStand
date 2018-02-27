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
        public Weather tomorrowsForcast;
        public Weather todaysWeather;
        double LemonadePrice;
        private LemonadeRecipe recipe;
        private Customer customer;
        private List<string> availableItems;
        public string purchaseInventory;
        public Random random;

        // constructor (SPAWNER)
        public Day()
        {
            random = new Random();
            tomorrowsForcast = new Weather();
            todaysWeather = new Weather();
            recipe = new LemonadeRecipe();
        }

        // member methods (CAN DO)
            //the shit we did today for set and grab (setting and getting)
    }
}
