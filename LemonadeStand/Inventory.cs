using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        // member variables (HAS A) 
        public List<Lemon> amountOfLemonsInPlayersInventoy;
        public List<Sugar> amountOfSugarInPlayersInventoy;
        public List<Ice> amountOfIceInPlayersInventoy;
        public List<Cup> amountOfCupsInPlayersInventoy;

        // constructor (SPAWNER)
        public Inventory()
        {
            amountOfLemonsInPlayersInventoy = new List<Lemon>();
            amountOfSugarInPlayersInventoy = new List<Sugar>();
            amountOfIceInPlayersInventoy = new List<Ice>();
            amountOfCupsInPlayersInventoy = new List<Cup>();
        }

        //CAN DO
        public void AddLemonToInventory(int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Lemon lemon = new Lemon();
                amountOfLemonsInPlayersInventoy.Add(lemon);
            }
        }

        public void AddSugarToInventory(int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Sugar sugar = new Sugar();
                amountOfSugarInPlayersInventoy.Add(sugar);
            }
        }

        public void AddIceToInventory(int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Ice Ice = new Ice();
                amountOfIceInPlayersInventoy.Add(Ice);
            }
        }

        public void AddCupToInventory(int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Cup cup = new Cup();
                amountOfCupsInPlayersInventoy.Add(cup);
            }
        }

        public void RemoveCupFromInventory(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Cup cup = new Cup();
                amountOfCupsInPlayersInventoy.RemoveAt(0);
            }
        }

        public void RemoveIceFromInventory(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Ice ice = new Ice();
                amountOfIceInPlayersInventoy.RemoveAt(0);
            }
        }

        public void RemoveSugarFromInventory(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Sugar sugar = new Sugar();
                amountOfSugarInPlayersInventoy.RemoveAt(0);
            }
        }
        public void RemoveLemonFromInventory(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Lemon lemon = new Lemon();
                amountOfLemonsInPlayersInventoy.RemoveAt(0);
            }
        }
    }
    }
