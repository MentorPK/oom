using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{
    class AllCards
    {
        static void Main(string[] args)
        {

            var CardgameX = new Card[]
                {
                    new Creature("Gandros",2, 5, 1,"Orc"),
                    new Creature("Aiunas", 4, 3, 5, "Elf"),
                    new Creature("Tandros",5, 5, 5,"Human"),
                    new Spell("Frostbolt",2,3,"Freeze"),
                    new Spell("Firebolt",4,6,"Burning"),
                    new Spell("Shadowbolt",3,2,"Weakness"),
                };

            foreach (var xy in CardgameX)
            {
                Console.WriteLine("Name:{0}, Mana:{1}, Power:{2}, ", xy.name, xy.mana, xy.powerlvl);
                xy.text();              
            } 

        }
    }
}
