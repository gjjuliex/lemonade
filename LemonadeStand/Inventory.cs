using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int lemon;
        public int ice;
        public int sugar;
        public int cups;
        public double budget = 20;
     
   

        public Inventory()
        {

        }

        public void SubtractInventory()
        {
            lemon = lemon - 2;
            ice = ice - 2;
            sugar = sugar - 1;
            cups = cups - 1;
            return leftove;

        }


        public void ShowMoney()
        {
            Console.WriteLine("Money leftover:{0}", leftoverBudget);
        }

  
        public void ShowInventory()
        {
            Console.WriteLine("You have {0} lemons, {1} cups, {2} cups of sugar, {3} bags of ice leftover!", lemons, cups, sugar, ice);
        }






    }
}
