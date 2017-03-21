using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{
    class Beginners:Wizards
    {
        public bool Castingpermission;
        public Beginners(string b_name, string b_spell, int b_powerlvl, bool permis)
        {
            Name = b_name;
            Spell = b_spell;
            Powerlvl = b_powerlvl;
            Castingpermission = permis;
        }
        public string Name { get; }
        public string Spell { get; }
        public int Powerlvl { get; }
        public void Power(int powerlvl)
        {
            if (powerlvl < 20)
            {
                Console.WriteLine("Zu schwach");
            }
            else
                Console.WriteLine("Stark genug");
        }
    }
}
