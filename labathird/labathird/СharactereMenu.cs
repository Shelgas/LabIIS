using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    static class СharactereMenu
    {

        public static Hero СreateHero()
        {
            Console.WriteLine("Choose your class:");

            while(true)
            {
                Console.WriteLine("Enter 1 to play as a mage");
                Console.WriteLine("Enter 2 to play as a warriror");
                Console.WriteLine("Enter 3 to play as a rogue");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        return ChooseClass(new MageBilder());
                    case "2":
                        return ChooseClass(new WarriorBilder());         
                    case "3":
                        return ChooseClass(new RogueBilder());
                    default:
                        Console.WriteLine("Error, try again");
                        break;
                }
            }

            

        }

        private static Hero ChooseClass(HeroBilder heroBilder)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            heroBilder.CreateHero(name);
            heroBilder.SetHealth();
            heroBilder.SetMana();
            heroBilder.SetStamina();
            heroBilder.SetStrength();
            heroBilder.SetIntelligence();
            heroBilder.SetAgility();
            heroBilder.SetTalents();
            heroBilder.SetImage();
            return heroBilder.Hero;
        }
    }
}
