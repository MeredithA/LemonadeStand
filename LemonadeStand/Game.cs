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
        public UI ui;

        // constructor ()
        public Game()
        {
            random = new Random();
            weather = new Weather();
            player = new Player();
            store = new Store();
            day = new Day();
            ui = new UI();
        }
        //member methods (CAN DO)

        public void RunGame()
        {
            UI.DisplayRules();
            day.todaysForcast.ActualWeatherCondition();
            day.todaysTempurature.ActualWeatherTemperature();
            day.PriceOfCup();
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
