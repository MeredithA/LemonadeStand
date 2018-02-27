using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Item
    {
        public double priceForItem;
        public string name;

        public Item()
        {

        }
        protected virtual double GetPricesOfItem()
        {
            return priceForItem;
        }
         
    }
}
