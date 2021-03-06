﻿using System;
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
        public bool validateFunds;
        public double totalProfit; //pretty sure this should be in the UI


        // constructor (SPAWNER)
        public Wallet()
        {
            moneyInWallet = 20.00;
        }


        // member methods (CAN DO)

        public void ValidateFunds(double balance, Player player)
        {
            if (balance <= moneyInWallet)
            {
                moneyInWallet -= balance;
            }
            else
            {
                Console.WriteLine("You do not have enough money to purchase everything in your cart.");
            }
        }

        public void DisplayBalance(Player player)
        {
            Console.WriteLine($"You currently have ${moneyInWallet} in your wallet.");
        }

        public void CalculateEndOfDayProfitOrLoss(Player player)
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

        public void DisplayEndOfWeekProfitOrLoss(Player player)
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
    }
}