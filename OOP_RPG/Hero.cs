using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Hero
    {
        /*This is a Constructor.
        When we create a new object from our Hero class, the instance of this class, our hero, has:
        an empty List that has to contain instances of the Armor class,
        an empty List that has to contain instance of the Weapon class,
        stats of the "int" data type, including an intial strength and defense,
        original hitpoints that are going to be the same as the current hitpoints.
        */
        public Hero()
        {
            this.ArmorsBag = new List<Armor>();
            this.WeaponsBag = new List<Weapon>();
            this.PotionBag = new List<Potion>();
            this.Strength = 10;
            this.Defense = 10;
            this.OriginalHP = 30;
            this.CurrentHP = 30;
            this.Gold = 0;
            this.Speed = 5;
        }

        // These are the Properties of our Class.
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }
        public int Speed { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }

        public List<Armor> ArmorsBag { get; set; }
        public List<Weapon> WeaponsBag { get; set; }
        public List<Potion> PotionBag { get; set; }


        //These are the Methods of our Class.
        public void ShowStats()
        {
            Console.WriteLine("*****" + this.Name + "*****");
            Console.WriteLine("Strength: " + this.Strength);
            Console.WriteLine("Defense: " + this.Defense);
            Console.WriteLine("Hitpoints: " + this.CurrentHP + "/" + this.OriginalHP);
            Console.WriteLine("Gold:" + this.Gold);
        }

        public void ShowInventory()
        {
            Console.WriteLine("*****  INVENTORY ******");
            Console.WriteLine("Weapons: ");
            foreach (var w in this.WeaponsBag)
            {
                Console.WriteLine(w.Name + " of " + w.Strength + " Strength");
            }
            Console.WriteLine("Armor: ");
            foreach (var a in this.ArmorsBag)
            {
                Console.WriteLine(a.Name + " of " + a.Defense + " Defense");
            }
        }

        public void EquipItem()
        {
            Console.WriteLine("1. Equip Weapon");
            Console.WriteLine("1. Equip Armor");
            var number = Console.ReadLine();
            if (number == "1")
            {
                if (this.WeaponsBag.Count > 0)
                {
                    foreach (var i in this.WeaponsBag)
                    {
                        Console.WriteLine(i + " : " + i.Name + " Strength " + i.Strength);
                    }
                    var item = Console.ReadLine();
                    if (item == "0" || item == "1" || item == "2")
                    {
                        this.EquipWeapon();
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (number == "2")
            {
                if (this.ArmorsBag.Count > 0)
                {
                    foreach (var i in this.ArmorsBag)
                    {
                        Console.WriteLine(i + " : " + i.Name + " Strength " + i.Defense);
                    }
                    var item = Convert.ToInt16(Console.ReadLine());
                    if (item == 0 || item == 1 || item == 2)
                    {
                        this.EquipArmor();
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        }
        public void EquipWeapon()
        {
            if (WeaponsBag.Any())
            {
                this.EquippedWeapon = this.WeaponsBag[0];
            }
        }

        public void EquipArmor()
        {
            if (ArmorsBag.Any())
            {
                this.EquippedArmor = this.ArmorsBag[0];
            }
        }

    }
}
