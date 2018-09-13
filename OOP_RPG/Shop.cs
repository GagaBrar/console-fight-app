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

        public Shop()
        {
            this.Weapons = new List<Weapon>();
            this.Armors = new List<Armor>();
            this.Potions = new List<Potion>();

        }
    }
}
