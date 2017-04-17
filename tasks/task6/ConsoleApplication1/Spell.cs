using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Spell:Card
    {
        public string effect;
        public Spell(string s_name, int s_mana, int s_powerlvl, string s_effect)
        {
            name = s_name;
            mana = s_mana;
            powerlvl = s_powerlvl;
            effect = s_effect;
        } 

        public string name { get; }
        public int mana { get; }
        public int powerlvl { get; }

        public void text()
        {
            if (effect == "Freeze")

            {
                Console.WriteLine("Freezes your creature and it can't attack on your next turn\n");
            }

            if (effect == "Burning")

            {
                Console.WriteLine("Deals your creature 1 damage every turn\n");
            } 

            if (effect == "Weakness")

            {
                Console.WriteLine("Your creature's attack is reduced by 2\n");
            }
        }
    }
}
