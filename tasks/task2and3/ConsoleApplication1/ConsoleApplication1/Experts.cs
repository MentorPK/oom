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
            name = e_name;
            spell = e_spell;
            powerlvl = e_powerlvl;
        }
        public string name { get; }
        public string spell { get; }

        public int powerlvl { get; }
        public void power(int powerlvl)
        {
            if (powerlvl > 20 && powerlvl <= 50)

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
