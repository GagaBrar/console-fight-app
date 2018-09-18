using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }

        public Fight(Hero hero, Game game)
        {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Squid", 9, 8, 20);
            this.AddMonster("Gorilla", 7, 8, 25);
            this.AddMonster("Big show", 9, 9, 50);
            this.AddMonster("Cathy", 8, 9, 60);
        }

        public void AddMonster(string name, int strength, int defense, int hp)
        {
            var monster = new Monster(name, strength, defense, hp);
            this.Monsters.Add(monster);
        }

        public void Start()
        {
            var enemy = this.Monsters[0];

            var SecondMonster = this.Monsters[1];
            var LastMonster = this.Monsters.Last();

            Console.WriteLine("You've encountered a " + enemy.Name + "! " + enemy.Strength + " Strength/" + enemy.Defense + " Defense/" +
            enemy.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. RunAway");
            Console.WriteLine("3. GetHealed");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.HeroTurn(enemy);
            }
            else if (input == "2")
            {
                this.RunAway();
            }

            else if (input == "3")
            {
                this.GetHealed();
            }

            else
            {
                this.game.Main();
            }
        }

        public void HeroTurn(Monster monster)
        {
            var enemy = monster;
            var compare = hero.Strength - enemy.Defense;
            int damage;

            if (compare <= 0)
            {
                damage = 1;
                enemy.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                enemy.CurrentHP -= damage;
            }
            Console.WriteLine("You did " + damage + " damage!");

            if (enemy.CurrentHP <= 0)
            {
                this.Win(enemy);
            }
            else
            {
                this.MonsterTurn(enemy);
            }

        }

        public void MonsterTurn(Monster monster)
        {
            var enemy = monster;
            int damage;
            var compare = enemy.Strength - hero.Defense;
            if (compare <= 0)
            {
                damage = 1;
                hero.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                hero.CurrentHP -= damage;
            }
            Console.WriteLine(enemy.Name + " does " + damage + " damage!");
            if (hero.CurrentHP <= 0)
            {
                this.Lose();
            }
            else
            {
                this.Start();
            }
        }
        public void RunAway()
        {
            if (hero.Speed > monster.Speed)
            {
                Console.WriteLine("You sucessfully escaped!!");

            }
            else
            {
                this.Start();
            }
        }

        public void GetHealed()
        {
            if (this.hero.PotionBag.Any())
            {
                this.hero.CurrentHP += this.hero.PotionBag.First().HP;
                this.hero.PotionBag.RemoveAt(0);
            }
        }
        public void Win(Monster monster)
        {
            var enemy = monster;
            hero.Gold = hero.Gold + monster.Gold;

            Console.WriteLine(enemy.Name + " has been defeated! You win the battle!");
            game.Main();
        }
         
        public void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }

    }

}