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
        public Player ()
        {
            name = GetName();
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
