using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Player
    {
        // member variables (HAS A) 
        public string nameOfLemonadeStand;
        double wallet;
        public string inventory;
        public string recipe;


       public double dailyPriceOfLemonade; 
        //a recipe
        public string dailyRecipe;

        //cutomer approval?


 

        // constructor (SPAWNER)
        public Player()
        {
            double.Player.wallet = 20;

            

        }

        // member methods (CAN DO)
        public abstract void setNameOfLemonadeStand()
        public abstract void getInventory()




        double wallet;
        public string inventory;
        public string recipe;
    }
}
