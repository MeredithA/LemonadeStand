using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory : Player
    {
        // member variables (HAS A) 
        public List<Lemon> playersLemons;
        public List<Sugar> playersSugar;
        public List<Ice> playersIce;
        public List<Cup> playersCups;

        // constructor (SPAWNER)
        public Inventory()
        {
            playersLemons = new List<Lemon>();
            playersSugar = new List<Sugar>();
            playersIce = new List<Ice>();
            playersCups = new List<Cup>();
        }

        //CAN DO
        public void AddLemon(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Lemon lemon = new Lemon();
                playersLemons.Add(lemon);
            }
        }
        public void AddCups(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Cup cup = new Cup();
                playersCups.Add(cup);
            }
        }
        public void AddSugar(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Sugar sugar = new Sugar();
                playersSugar.Add(sugar);
            }
        }
        public void AddIce(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Ice ice = new Ice();
                playersIce.Add(ice);
            }
        }

        public void RemoveIce(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Ice ice = new Ice();
                playersIce.RemoveAt(0);
            }
        }
        public void RemoveSugar(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Sugar sugar = new Sugar();
                playersSugar.RemoveAt(0);
            }
        }
        public void RemoveLemon(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Lemon lemon = new Lemon();
                playersLemons.RemoveAt(0);
            }
        }
        public void RemoveCups(double Number)
        {
            for (double i = 0; i < Number; i++)
            {
                Cup cups = new Cup();
                playersCups.RemoveAt(0);
            }
        }

        }
    }
