using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables (HAS A)
        private UI UI;
        private Player playerOne;
        private Player playerTwo;        
        private Day day;
        private Store store;
        private Item items;
        private Lemon lemons;
        private Sugar sugar;
        private Ice ice;
        private Cup cups;
        

        // constructor ()
        public Game()
        {
            playerOne = new Human();
            playerTwo = new Computer();
 /*           availableItems = new List<string>() { "Lemons", "Sugar", "Vodka", "Cups", "Ice" };
            random = new Random();
            // lengthOfGame?
        }


        //member methods (CAN DO)
        public void RunGame()
        {
     //       bool willPlayAgain = AskToPlayAgain();
            if (willPlayAgain)
            {
                RunGame();
            }
        }

        private void SetUpGame()
        {
            UI.DisplayGameRules();
            // playerTwo = DetermineOpponentType();
            playerOne.SetName();
            // playerTwo.SetName();
  */      }
       
    }
}