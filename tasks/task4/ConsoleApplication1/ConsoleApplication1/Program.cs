using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

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

            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            var jsonw = JsonConvert.SerializeObject(Magician, settings);
            var dir = Directory.GetCurrentDirectory();
            var filename = Path.Combine(dir, "Wizards.json");
            File.WriteAllText(filename, jsonw);

            var x = File.ReadAllText(filename);
            var y = JsonConvert.DeserializeObject<Wizards[]>(x, settings);

            foreach (var a in y)
            {
                Console.WriteLine("Name:{0}, Spell:{1}, Powerlvl:{2}", a.Name, a.Spell, a.Powerlvl);
                a.Power(a.Powerlvl);
                
            }

        }
    }

}
