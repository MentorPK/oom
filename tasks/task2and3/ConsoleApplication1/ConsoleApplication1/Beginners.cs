using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{
    class Beginners:Wizards
    {
        private bool castingpermission;
        public Beginners(string b_name, string b_spell, int b_powerlvl, bool permis)
        {
            name = b_name;
            spell = b_spell;
            powerlvl = b_powerlvl;
            castingpermission = permis;
        }
        public string name { get; }
        public string spell { get; }
        public int powerlvl { get; }
        public void power(int powerlvl)
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
