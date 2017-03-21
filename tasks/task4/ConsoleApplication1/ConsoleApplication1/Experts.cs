using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{
    class Experts:Wizards
    { 
        public Experts(string e_name, string e_spell, int e_powerlvl)
        {
            Name = e_name;
            Spell = e_spell;
            Powerlvl = e_powerlvl;
        }
        public string Name { get; }
        public string Spell { get; }

        public int Powerlvl { get; }
        public void Power(int powerlvl)
        {
            if (Powerlvl > 20 && Powerlvl <= 50)

            {
                Console.WriteLine("langsam naeherst du dich deinem Ziel");
            }

            else if (powerlvl > 50 && powerlvl <= 80)
            {
                Console.WriteLine("deine spells haben langsam was drauf");
            }
            else
                Console.WriteLine("du gehoerst zu den maechtisten!");
        }
    }
}
