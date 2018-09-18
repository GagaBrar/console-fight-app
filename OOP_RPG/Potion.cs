using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Potion : ItemI
    {
        public Potion(int hp, string name, int originalvalue, int resellvalue)
        {
            this.HP = hp;
            this.Name = name;
            this.OriginalValue = originalvalue;
            this.ResellValue = resellvalue;

        }

        public int HP { get; set; }
        public string Name { get; set; }

        public int ResellValue { get; set; }
        public int OriginalValue { get; set; }
    }
}