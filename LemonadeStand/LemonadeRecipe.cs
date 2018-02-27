using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeRecipe
    {
        // menmber variables(HAS)
        public int numberOfLemonsUsedInRecipe;
        public int amountOfSugarForRecipe;
        public int amountOfIceCubesForRecipe;
    

        // constructor (SPAWNER)
        public LemonadeRecipe()
        {
            //set recipe to zero
        }

        // member methods (CAN DO)
        public void getNumberOfLemonsForRecipe()
        {
            Console.WriteLine("How many lemons would you like to use in your recipe?");

            int numberOfLemonsForRecipe = int.Parse(Console.ReadLine());
            numberOfLemonsUsedInRecipe = numberOfLemonsForRecipe;
        }

         public int getamountOfSugarForRecipe()
        {
            Console.WriteLine("How many cups of sugar would you like to use in your recipe?");

            int amountOfSugarForRecipe = int.Parse(Console.ReadLine());
            return this.amountOfSugarForRecipe = amountOfSugarForRecipe;
        }

        public int getamountOfIceCubesForRecipe()
        {
            Console.WriteLine("How many ice cubs would like to put in the cup?");

            int amountOfIceCubesForRecipe = int.Parse(Console.ReadLine());
            return this.amountOfIceCubesForRecipe = amountOfIceCubesForRecipe;
        }
    }
    }