using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class Program
    {
        static void Main(string[] args)
        {
            СharactereMenu cm = new СharactereMenu();

            Hero warrior = cm.СreateHero(new WarriorBilder(), "Garrosh");
            Console.WriteLine(warrior.GetCharacteristics());


            //Hero mage = cm.СreateHero(new MageBilder(), "Jaina");
            //Console.WriteLine(mage.GetCharacteristics());

            //Hero rogue = cm.СreateHero(new RogueBilder(), "*****");
            //Console.WriteLine(rogue.GetCharacteristics());
          

            Console.Read();
        }
    }
}
