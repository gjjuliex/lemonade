using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemon;
        public int sugar;
        public int ice;
        public int cup;
        public double lemonadePrice;

        public Recipe()
        {


        }

        public void StartRecipe(Player player)
        {
            Console.WriteLine("Time to make Lemonade!");
            Console.WriteLine("How would you like to begin?");
            Console.WriteLine("type 'start' to start making your recipe, \n'check' to see inventory, \n'shop' to shop some more!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "start":


                case "check":
                    name.inventory.DisplayInventory();
                    StartRecipe(player);
                    break;

                case "shop":
                    Store();
                    break;

            }

        }
        public int PickLemons()
        {
            Console.WriteLine("How many lemons does your recipe call for?");
            lemon = int.Parse(Console.ReadLine());
            return lemon;
        }
        public bool CheckLemonInventory()
        {
            if (name.inventory.lemons[0].Count < lemon)
            {
                Console.WriteLine("You don't have enough lemons");
                PickLemons();
            }
            return true;
        }

        public int PickSugar()
        {
            Console.WriteLine("How much sugar does your recipe need?");
            sugar = int.Parse(Console.ReadLine());
            return sugar;
        }
        public bool CheckSugar()
        {
            if (player.inventory.sugar[0].Count < sugar)
            {
                Console.WriteLine("You don't have enough sugar");
                PickSugar();
            }
            return true;
        }
        
        public int PickIce()
        {
            Console.WriteLine("How much ice does your recipe need?");
            ice = int.Parse(Console.ReadLine());
            return ice;
        }
        
        public bool CheckIce()
        {
            if (player.inventory.ice[0].Count < ice)
            {
                Console.WriteLine("Uh oh, you don't have enough ice!");
                PickIce();
            }
            return true;
        }

        public int PickCup()
        {
            Console.WriteLine("How many cups of lemonade you making today?");
            cup = int.Parse(Console.ReadLine());
            return cup;
        }

        public bool CheckCup()
        {
            if (player.inventory.cup[0].Count < cup)
            {
                Console.WriteLine("You ran out of cups, how are you going to hold your lemonade now? :(");
                PickCup();
            }
            return true;
        }
    }
}



