using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Inventory inventory;
        public Player ()
        {
            name = GetName();
            inventory = new Inventory();
        }

        public string GetName()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            return name;

        }

        public Recipe recipe;

    }
}
