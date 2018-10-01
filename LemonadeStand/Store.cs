using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public int numberLemons;
        public int numberIce;
        public int numberSugar;
        public int numberCups;
        public int price;
        public double money;
        public double moneySpent;
        public double earnings;
        public string yesOrNo;
        Inventory inventory = new Inventory();


        public Store()
        {


        }

        public double BuyLemons()
        {
            Console.WriteLine($"You have {inventory.lemon} lemons!");
            Console.WriteLine("Lemons cost 25 cents, would you like to purchase more? If so how many?");
            try
            {
                numberLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number, either a whole positive number or zero!");
                return BuyLemons();
            }
            Console.Write("Are you sure you want to buy {0}?  Yes/No  ", numberLemons);
            yesOrNo = Console.ReadLine();
            switch (yesOrNo)
            {
                case "Yes":
                    inventory.lemon = inventory.lemon + numberLemons;
                    inventory.money = inventory.money - (numberLemons * .25);
                    Console.WriteLine("You have purchased {0} lemons", numberLemons);
                    inventory.MoneyBalance();
                    break;
                case "No":
                    BuyLemons();
                    break;
                default:
                    Console.WriteLine("You've entered something invalid, please try again");
                    BuyLemons();
                    break;
            }
            return inventory.money;
        }

        public double BuySugar()
        {
            Console.WriteLine($"You have {inventory.sugar} cups of sugar!");
            Console.WriteLine("Sugar cost 20 cents, would you like to purchase more? If so how many?");
            try
            {
                numberLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number, either a whole positive number or zero!");
                return BuyLemons();
            }
            Console.Write("Are you sure you want to buy {0}?  Yes/No  ", numberSugar);
            yesOrNo = Console.ReadLine();
            switch (yesOrNo)
            {
                case "Yes":
                    inventory.sugar = inventory.sugar + numberSugar;
                    inventory.money = inventory.money - (numberSugar * .2);
                    Console.WriteLine("You have purchased {0} cups of sugar", numberSugar);
                    inventory.MoneyBalance();
                    break;
                case "No":
                    BuySugar();
                    break;
                default:
                    Console.WriteLine("You've entered something invalid, please try again");
                    BuySugar();
                    break;
            }
            return inventory.money;
        }

        public double BuyIce()
        {
            Console.WriteLine($"You have {inventory.ice} bags of ice!");
            Console.WriteLine("Ice cost 20 cents, would you like to purchase more? If so how many?");
            try
            {
                numberLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number, either a whole positive number or zero!");
                return BuyLemons();
            }
            Console.Write("Are you sure you want to buy {0}?  Yes/No  ", numberIce);
            yesOrNo = Console.ReadLine().ToLower();
            switch (yesOrNo)
            {
                case "Yes":
                    inventory.ice = inventory.ice + numberIce;
                    inventory.money = inventory.money - (numberLemons * .2);
                    Console.WriteLine("You have purchased {0} bags of ice", numberIce);
                    inventory.MoneyBalance();
                    break;
                case "No":
                    BuyIce();
                    break;
                default:
                    Console.WriteLine("You've entered something invalid, please try again");
                    BuyIce();
                    break;
            }
            return inventory.money;
        }
        public double BuyCups()
        {
            Console.WriteLine($"You have {inventory.cups} cups!");
            Console.WriteLine("Cups cost 15 cents, would you like to purchase more? If so how many?");
            try
            {
                numberLemons = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number, either a whole positive number or zero!");
                return BuyCups();
            }
            Console.Write("Are you sure you want to buy {0}?  Yes/No  ", numberCups);
            yesOrNo = Console.ReadLine();
            switch (yesOrNo)
            {
                case "Yes":
                    inventory.ice = inventory.ice + numberLemons;
                    inventory.money = inventory.money - (numberIce * .15);
                    Console.WriteLine("You have purchased {0} lemons", numberIce);
                    inventory.MoneyBalance();
                    break;
                case "No":
                    BuyIce();
                    break;
                default:
                    Console.WriteLine("You've entered something invalid, lease try again");
                    BuyIce();
                    break;
            }
            return inventory.money;
        }

        public int PriceLemonade()
        {
            {
                Console.WriteLine("How much would you like to sell your lemonade for?");
                price = int.Parse(Console.ReadLine());
                PriceLemonade();
                
            }
            return price;


        }
    }


    }

 




