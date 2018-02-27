using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human : Player
    {
        // member variables (HAS A)

        // constructor (SPAWNER)
        public Human()
        {
        }

        // member methods (CAN DO)

        public string GetLemonadeStandName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }

        public int getInventory()
        {
            return 1;
        }
    }
}
