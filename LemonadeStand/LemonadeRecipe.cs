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
        public int amountOfCupsUsed;
    

        // constructor (SPAWNER)
        public LemonadeRecipe()
        {
        numberOfLemonsUsedInRecipe = 0;
        amountOfSugarForRecipe = 0;
        amountOfIceCubesForRecipe = 0;
        amountOfCupsUsed = 0;
        }

        // member methods (CAN DO)
        public void GetNumberOfLemonsForRecipe(Day day)
        {
            Console.WriteLine("How many lemons would you like to use in your recipe?");

            int numberOfLemonsForRecipe = int.Parse(Console.ReadLine());
            numberOfLemonsUsedInRecipe = numberOfLemonsForRecipe;
        }

         public int GetAmountOfSugarForRecipe(Day day)
        {
            Console.WriteLine("How many cups of sugar would you like to use in your recipe?");

            int amountOfSugarForRecipe = int.Parse(Console.ReadLine());
            return this.amountOfSugarForRecipe = amountOfSugarForRecipe;
        }

        public int GetAmountOfIceCubesForRecipe(Day day)
        {
            Console.WriteLine("How many ice cubs would like to put in the cup?");

            int amountOfIceCubesForRecipe = int.Parse(Console.ReadLine());
            return this.amountOfIceCubesForRecipe = amountOfIceCubesForRecipe;
        }

        //public int GetAmountOfCupsUsed(Day day)
        //{ 
        
        //}
    }
    }