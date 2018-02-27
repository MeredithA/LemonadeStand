using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        // member variables (HAS A)
        public double moneyInWallet;
        bool ValidateFunds;
        double costOfProduct;
        public double totalProfit;
        double DailyFinacialReport;

        // constructor (SPAWNER)
        public Wallet()
        {
            moneyInWallet = 20.00;
            totalProfit = 0;
        }


        // member methods (CAN DO)
        public void DisplayBalance(Player player)
        {
            Console.WriteLine($"You currently have ${moneyInWallet} in your wallet.");
        }

        public void CalculateEndOfDayProfitOrLoss()
        {
            double dailyProfitOrLoss;
            double startingAmount = 20;
            dailyProfitOrLoss = moneyInWallet - startingAmount;
            if (dailyProfitOrLoss > 0)
            {
                Console.WriteLine($"You made ${dailyProfitOrLoss} today!");
                Console.ReadLine();
            }
            else if (dailyProfitOrLoss < 0)
            {
                Console.WriteLine($"You lost $ {dailyProfitOrLoss} today!");
                Console.WriteLine("=(");
                Console.ReadLine();
            }
            totalProfit += dailyProfitOrLoss;
        }

        public void DisplayEndOfWeekProfitOrLoss()
        {
            if (totalProfit > 0)
            {
                Console.WriteLine($"You made ${totalProfit} this week!");
                Console.ReadLine();
            }
            else if (totalProfit < 0)
            {
                Console.WriteLine($"You lost $ {totalProfit} this week!");
                Console.WriteLine("='(");
                Console.ReadLine();
            }
        }


        public bool CheckWallet(double CostOfProduct)
        {
            if (moneyInWallet < CostOfProduct)
            {
                ValidateFunds = true;
                Console.WriteLine("You don't have enough money to purchase this item.");
            }
            return ValidateFunds;
        }


        // daily debits - daily credits
    }
}