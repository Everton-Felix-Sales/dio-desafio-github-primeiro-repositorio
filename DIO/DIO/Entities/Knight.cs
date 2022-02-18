using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Entities
{
    class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        
        public string Attack(int Bonus)
        {
            if (Bonus >= 8)
            {
                return this.Name + " Atacou com sua espada super efetiva com bonus de  " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com sua espada com força fraca com bonus de " + Bonus;
            }

        }
    }
}
