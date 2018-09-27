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
            ice = ice - 1;
            sugar = sugar - 1;
            cups = cups - 2;
        }






    }
}
