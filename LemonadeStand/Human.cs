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
        private string nameOfLemonadeStand;


        // constructor (SPAWNER)
        public Human()
        {

        }

        // member methods (CAN DO)
        public override void SetLemonadesStandName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }
    }
}
