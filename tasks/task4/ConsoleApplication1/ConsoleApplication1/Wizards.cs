using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{ interface Wizards
    {
        string Name { get; }
        string Spell { get; }
        int Powerlvl { get; }
        void Power (int powerlvl);
    }
}
