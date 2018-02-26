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
        double profit;
        double expenses;
        double income;
        public string inventory;
        private Wallet wallet;


        // constructor (SPAWNER)
        public Player()
        {
            double wallet  = 20;
        }

        // member methods (CAN DO)
        public abstract void setNameOfLemonadeStand()
        public abstract void getInventory()




        double wallet;
        public string inventory;
        public string recipe;
    }
}
