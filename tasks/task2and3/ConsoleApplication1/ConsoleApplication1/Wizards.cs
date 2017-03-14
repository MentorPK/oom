using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{ interface Wizards
    {
        string name { get; }
        string spell { get; }
        int powerlvl { get; }
        void power (int powerlvl);
    }
}
