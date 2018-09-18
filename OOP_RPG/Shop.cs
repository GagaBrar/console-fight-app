using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        List<Weapon> Weapons { get; set; }
        List<Armor> Armors { get; set; }
        List<Potion> Potions { get; set; }
        public Hero hero { get; set; }
        public Game game { get; set; }


        public Shop(Hero hero, Game game)
        {
            this.Weapons = new List<Weapon>();
            this.Armors = new List<Armor>();
            this.Potions = new List<Potion>();
            this.game = game;
            this.hero = hero;
            this.Weapons.Add(new Weapon("Sword", 10, 2, 3));
            this.Weapons.Add(new Weapon("Axe", 12, 3, 4));
            this.Weapons.Add(new Weapon("Longsword", 20, 5, 7));
            this.Armors.Add(new Armor("Wooden Armor", 10, 2, 3));
            this.Armors.Add(new Armor("Metal Armor", 20, 5, 7));
            this.Potions.Add(new Potion(10, "Healing Potion", 10, 5));

        }
        public void Menu()
        {
            Console.WriteLine("Welcome to My Shop. What you want?");
            Console.WriteLine("1.Buy Item");
            Console.WriteLine("2.Sell Item");
            Console.WriteLine("3.Return to the game");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyFromUser();
            }
            else if (input == "3")
            {
                this.game.Main();
            }
        }
        public void ShowInventory()
        {

            Console.WriteLine("What you want to buy?");
            Console.WriteLine("1.Weapons");
            Console.WriteLine("2.Armors");
            Console.WriteLine("3.Potions");
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Enter Number of the item Or press r to return menu");
                for (int i = 0; i < Weapons.Count; i++)
                {
                    Console.WriteLine(i + " " + Weapons[i].Name + " $" + Weapons[i].OriginalValue);
                }
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber < this.Weapons.Count)
                {
                    this.sell(inputNumber, "weapons");
                }
                else
                {
                    this.Menu();
                }
            }
            else if (input == "2")
            {
                for (int i = 0; i < Armors.Count; i++)
                {
                    Console.WriteLine(i + " " + Armors[i].Name + " $" + Armors[i].OriginalValue);
                }
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber < this.Armors.Count)
                {
                    this.sell(inputNumber, "armor");
                }
                else
                {
                    this.Menu();
                }

            }
            else if (input == "3")
            {
                for (int i = 0; i < Potions.Count; i++)
                {
                    Console.WriteLine(i + " " + Potions[i].Name + " $" + Potions[i].OriginalValue);
                }
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber < this.Potions.Count)
                {
                    this.sell(inputNumber, "potion");
                }
                else
                {
                    this.Menu();
                }
            }
            else
            {
                this.Menu();
            }
        }


        public void BuyFromUser()
        {

        }

        public void SellFromUser()
        {


        }

        public void sell(int number, string name)
        {

        }
    }
}