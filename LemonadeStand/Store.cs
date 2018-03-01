using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store 
    {
        //member variables (HAS A)
        public double priceOf25Cups;
        public double priceOf50Cups;
        public double priceOf100Cups;

        public double priceOf8CupsOfSugar;
        public double priceOf20CupsOfSugar;
        public double priceOf48CupsOfSugar;

        public double priceOf10Lemons;
        public double priceOf30Lemons;
        public double priceOf75Lemons;

        public double priceOf100IceCubes;
        public double priceOf200IceCubes;
        public double priceOf300IceCubes;


        //constructor
        public Store()
        {
            priceOf10Lemons = 0.64;
            priceOf30Lemons = 2.48;
            priceOf75Lemons = 4.06;

            priceOf25Cups = 0.91;
            priceOf50Cups = 1.68;
            priceOf100Cups = 3.04;

            priceOf8CupsOfSugar = 0.72;
            priceOf20CupsOfSugar = 1.66;
            priceOf48CupsOfSugar = 3.44;

            priceOf100IceCubes = 0.86;
            priceOf200IceCubes = 2.21;
            priceOf300IceCubes = 3.79;
        }

        //member methods
        public void SelectTypeOfItem(Player player)
        {
            Console.WriteLine("If you need lemons, type 'lemons'.");
            Console.WriteLine("If you need cups, type 'cups'.");
            Console.WriteLine("If you need sugar, type 'sugar'.");
            Console.WriteLine("If you need ice cubes, type 'ice cubes'.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "lemons":
                    Console.WriteLine("10 Lemons: " + priceOf10Lemons);
                    Console.WriteLine("30 Lemons: " + priceOf30Lemons);
                    Console.WriteLine("75 Lemons: " + priceOf75Lemons);
                    break;
                case "cups":
                    Console.WriteLine("25 cups: " + priceOf25Cups);
                    Console.WriteLine("50 cups: " + priceOf50Cups);
                    Console.WriteLine("100 cups: " + priceOf100Cups);
                    break;
                case "sugar":
                    Console.WriteLine("8 Cubes of sugar: " + priceOf8CupsOfSugar);
                    Console.WriteLine("20 Cubes of sugar: " + priceOf20CupsOfSugar);
                    Console.WriteLine("48 Cubes of sugar: " + priceOf48CupsOfSugar);
                    break;
                case "ice cubes":
                    Console.WriteLine("100 ice cubes: " + priceOf100IceCubes);
                    Console.WriteLine("200 ice cubes: " + priceOf200IceCubes);
                    Console.WriteLine("300 ice cubes: " + priceOf300IceCubes);
                    break;
                default:
                    Console.WriteLine("You have entered an invalid item type.");
                    break;
            }

        }

        public double ChoosingLemons(Player player)
        {
            Console.WriteLine("Would you like to by 10, 30 or 75 lemons?");
            string numberOfLemons = Console.ReadLine();

            double cost = 0;

            switch (numberOfLemons)
            {
                case "10":
                    Console.WriteLine("You bought 10 lemons.");
                    player.inventory.AddLemonToInventory(10);
                    break;
                case "30":
                    Console.WriteLine("You bought 30 lemons.");
                    player.inventory.AddLemonToInventory(30);
                    cost = priceOf30Lemons;
                    break;
                case "75":
                    Console.WriteLine("You bought 75 lemons.");
                    player.inventory.AddLemonToInventory(75);
                    cost = priceOf75Lemons;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid quantity.");
                    break;
            }
            return cost;
        }

        public double ChoosingCups(Player player)
        {
            Console.WriteLine("Would you like to by 25, 50 or 100 cups?");
            string numberOfCups = Console.ReadLine();

            double cost = 0;

            switch (numberOfCups)
            {
                case "25":
                    Console.WriteLine("You bought 25 cups.");
                    player.inventory.AddCupToInventory(25);
                    cost = priceOf25Cups;
                    break;
                case "50":
                    Console.WriteLine("You bought 50 cups.");
                    player.inventory.AddCupToInventory(50);
                    cost = priceOf50Cups;
                    break;
                case "100":
                    Console.WriteLine("You bought 100 cups.");
                    player.inventory.AddCupToInventory(100);
                    cost = priceOf100Cups;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid quantity.");
                    break;
            }
            return cost;
        }


        public double ChoosingSugar(Player player)
        {
            Console.WriteLine("Would you like to buy 8, 20 or 48 cups of sugar?");
            string cupsOfSugar = Console.ReadLine();

            double cost = 0;

            switch (cupsOfSugar)
            {
                case "8":
                    Console.WriteLine("You bought 8 cups of sugar.");
                    player.inventory.AddSugarToInventory(8);
                    cost = priceOf8CupsOfSugar;
                    break;
                case "20":
                    Console.WriteLine("You bought 20 cups of sugar.");
                    player.inventory.AddSugarToInventory(20);
                    cost = priceOf20CupsOfSugar;
                    break;
                case "48":
                    Console.WriteLine("You bought 48 cups of sugar.");
                    player.inventory.AddSugarToInventory(48);
                    cost = priceOf48CupsOfSugar;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid quantity.");
                    break;
            }
            return cost;
        }

        public double ChoosingIceCubes(Player player)
        {
            Console.WriteLine("Would you like to by 100, 200 or 300 ice cubes?");
            string numberOfIceCubes = Console.ReadLine();

            double cost = 0;

            switch (numberOfIceCubes)
            {
                case "100":
                    Console.WriteLine("You bought 100 ice cubes.");
                    player.inventory.AddIceToInventory(100);
                    cost = priceOf100IceCubes;
                    break;
                case "250":
                    Console.WriteLine("You bought 200 ice cubes.");
                    player.inventory.AddIceToInventory(200);
                    cost = priceOf200IceCubes;
                    break;
                case "500":
                    Console.WriteLine("You bought 500 ice cubes.");
                    player.inventory.AddIceToInventory(500);
                    cost = priceOf300IceCubes;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid quantity.");
                    break;
            }
            return cost;
        }

        //    public string purchaseMoreItems (Player player)
        //    {

        //        Console.WriteLine("Do you need any other items? Type 'yes' or 'no'.");
        //        string purchaseMoreItems = Console.ReadLine();

        //        switch (purchaseMoreItems)
        //        {
        //            case "yes":
        //                Console.WriteLine("What item do you need more of?");
        //                break;
        //            case "no":
        //                Console.WriteLine("Your total inventory is:");
        //                inventory.displayInventory();
        //                break;
        //            default:
        //                Console.WriteLine("Invalid entery.");
        //                break;
        //        }
        //}
    }
}

