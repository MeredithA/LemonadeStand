using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
class Lemon : Item
{
        // member variables (HAS A)
        double priceOf10Lemons;
        double priceOf30Lemons;
        double priceOf75Lemons;


    // constructor (SPAWNER)
    public Lemon()
    {
        priceOf10Lemons = 0.64;
        priceOf30Lemons = 2.48;
        priceOf75Lemons = 4.06;
    }




    // member methods (CAN DO)
    //        protected virtual double GetPriceOfItem()

    }
}

