﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Item
    {
        public double priceOf100IceCubes;
        public double priceOf200IceCubes;
        public double priceOf300IceCubes;

        // constructor (SPAWNER)
        public Cup()
        {
            priceOf100IceCubes = 0.86;
            priceOf200IceCubes = 2.21;
            priceOf300IceCubes = 3.79;
        }


        // member methods (CAN DO)
        //        protected virtual double GetPriceOfItem()
    }
}
