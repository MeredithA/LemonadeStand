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
        public Random random;
        public Weather weather;
        public Player player;
        public Store store;
        public Day day;
        // public UI ui;

        // constructor ()
        public Game()
        {
            random = new Random();
            weather = new Weather();
            player = new Player();
            store = new Store();
            day = new Day();
            // ui = new UI();
        }
        //member methods (CAN DO)

        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand.");
            Console.WriteLine("Instructions:");
            Console.WriteLine("Your goal is to make as much money as you can in 7 days.");
            Console.WriteLine("Buy cups, lemons, sugar and ice cubes. Then set your recipe every day.");
            Console.WriteLine("Pay close attention to the weather and customer satisfaction.");
            Console.WriteLine("Please hit [ENTER] to continue.");
            Console.ReadLine();
        }

        public void DisplayPlayerInventory()
        {

        }

        public void RestartGame()
        {
            Console.WriteLine("Would you like to replay the game? Type 'yes' or 'no'.");
            string answer = Console.ReadLine().ToUpper();
            switch (answer)
            {
                case "yes":
                    RunGame();
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalaid entry.");
                    break;

            }
        }
    }
}
