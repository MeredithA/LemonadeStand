using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Items

    {
        // member variables (HAS A)
        public string getItemQuantity;
        public int getPriceForItem;
        public int currentItmsInInventory;

        // constructor (SPAWNER)
        public abstract void getItemQuantity()
        {
            
        }

        public abstract void currentItemsInInventory()
        {
            currentItmsInInventory = 0;
        }

        // member methods (CAN DO)
        internal void increaseScore()
        {

        }
    }
}
