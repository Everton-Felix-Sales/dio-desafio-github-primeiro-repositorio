using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Entities
{
    class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou a sua kunai ";
        }
        public string Attack(int Bonus)
        {
            if (Bonus >= 15)
            {
                return this.Name + " Lançou a sua kunai super efetiva com bonus de  " + Bonus;
            }
            else
            {
                return this.Name + " Lançou a sua kunai com força fraca com bonus de " + Bonus;
            }

        }
    }
}
