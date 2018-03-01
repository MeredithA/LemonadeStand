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
        public Inventory inventory;
        public Wallet wallet;
        public string nameOfLemonadeStand;

        // constructor (SPAWNER)
        public Player()
        {
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
        }

        public void GetNameOfLemonadeStand()
        {
            Console.WriteLine("What is the name of your Lemonade Stand?");
            nameOfLemonadeStand = Console.ReadLine();
            Console.Clear();
        }
    }
}