using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2and3
{
    class Magic
    {
        static void Main(string[] args)
        {

            var Magician = new Wizards[]
                {
                    new Beginners("Jaina","Blizzard",18,false),
                    new Beginners("Darian", "Impulse Shock", 5, false),
                    new Experts("Guldan","Hellfire",99),
                    new Experts("Medivh","Arcane Blast",49),

                };


            foreach (var a in Magician)
            {
                Console.WriteLine("Name:{0}, Spell:{1}, Powerlvl:{2}", a.name, a.spell, a.powerlvl);
                a.power(a.powerlvl);
                
            }

        }
    }

}
