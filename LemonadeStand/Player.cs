using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A) 
        public string GetLemonadesStandName;
        public Inventory Inventory;
        public Wallet wallet;
        public LemonadeRecipe lemonaderecipe;
        public int numberOfItemsBought;
        public double DeductPurchasedItemsFromWallet;

        // constructor (SPAWNER)
        public Player()
        {
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
            LemonadeRecipe lemonaderecipe = new LemonadeRecipe();

        }
    }
}