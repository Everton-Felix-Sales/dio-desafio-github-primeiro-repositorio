using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia ";
        }
        public string Attack(int Bonus)
        {
            if(Bonus >= 5)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de  " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
           
        }
    }
}
