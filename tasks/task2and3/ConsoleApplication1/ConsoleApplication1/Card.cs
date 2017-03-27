using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{ interface Card
    {
        string name { get; }
        int mana { get; }
        int powerlvl { get; }

        void text ();
    }
}
