using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int lemon;
        public int ice;
        public int sugar;
        public int cups;
        public double money = 20;
       
     
   

        public Inventory()
        {

        }
  
        public void DisplayInventory()
        {
            Console.WriteLine("You have {0} lemons, {1} cups, {2} cups of sugar, {3} bags of ice!", lemon, cups, sugar, ice);

        }
        public void MoneyBalance()
        {
            Console.WriteLine("Your balance is {0}", money);
        }






    }
}
