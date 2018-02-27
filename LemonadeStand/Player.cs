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
        public string GetLemonadesStandName;
        //public string PurchaseInventory;
        
        double profit;
        double expenses;
        double income;
        public double money;
        public double moneyForStore;
        public Inventory inventory;
        private Wallet wallet;
        public int numberOfItemsBought;


        // constructor (SPAWNER)
        public Player()
        {
        numberOfItemsBought = 0;
        moneyForStore = 20.00;

        inventory.playersCups = 0;
        inventory.playersIce = 0;
        inventory.playersSugar = 0;
        inventory.playersLemons = 0;
        }

        // member methods (CAN DO)
        public void PurchaseInventory()
        {

        }
        public void DisplayPlayerInventory()
        {
            Console.WriteLine("Cups: {0}", inventory.playersCups);
            Console.WriteLine("Ice: {0}", inventory.playersIce);
            Console.WriteLine("Sugar: {0}", inventory.playersSugar);
            Console.WriteLine("Lemons: {0}", inventory.playersLemons);
        }
    }
}