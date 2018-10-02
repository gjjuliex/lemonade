using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Player player;
        public int numberOfDays = 7;
        public string choice;
        Store store = new Store();
        Customer1 customer = new Customer1();
        Weather weather = new Weather();
        public Recipe recipe;
        public Random rand;
        public Days currentDay;

        public Game()
        {
            player = new Player();
            store = new Store();
            recipe = new Recipe();
            rand = new Random();
            currentDay = new Days();

        }
        
        public void StartGame()
        {
            runGame();
        }
        public void runGame()
        {
            currentDay.DisplayDay();
            player.inventory.DisplayIvente
           
        }
            
        
    }
}
