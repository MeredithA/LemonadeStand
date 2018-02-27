using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup : Item
    {
        public double priceOf25Cups;
        public double priceOf50Cups;
        public double priceOf100Cups;


        // constructor (SPAWNER)
        public Cup()
        {
            priceOf25Cups = 0.91;
            priceOf50Cups = 1.68;
            priceOf100Cups = 3.04;
        }


        // member methods (CAN DO)
        //        protected virtual double GetPriceOfItem()
    }
}
