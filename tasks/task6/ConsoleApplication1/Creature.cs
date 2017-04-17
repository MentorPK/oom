using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Creature:Card
    {
        public int defenselvl;
        public string typus;
        public Creature(string c_name, int c_mana, int c_powerlvl, int c_defenselvl, string c_typus)
        {
            name = c_name;
            mana = c_mana;
            powerlvl = c_powerlvl;
            defenselvl = c_defenselvl;
            typus = c_typus;
        }
        public string name { get; }
        public int mana { get; }
        public int powerlvl { get; }

        public void text()
        {
            if (powerlvl < defenselvl)
            {
                Console.WriteLine("Tank Card\n");
            }
            else if (powerlvl > defenselvl)
            {
                Console.WriteLine("Slayer Card\n");
            }
            else
                Console.WriteLine("Guardian Card\n");
        }
    }
}
