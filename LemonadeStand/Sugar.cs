using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Item
    {
        // member variables (HAS A)
        public double priceOf8CupsOfSugar;
        public double priceOf20CupsOfSugar;
        public double priceOf48CupsOfSugar;


        // constructor (SPAWNER)
        public Sugar()
        {
            priceOf8CupsOfSugar = 0.72;
            priceOf20CupsOfSugar = 1.66;
            priceOf48CupsOfSugar = 3.44;
        }




        // member methods (CAN DO)
        //        protected virtual double GetPriceOfItem()
    }
}
