using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class СharactereMenu
    {
        public Hero СreateHero(HeroBilder heroBilder, string name)
        {
            heroBilder.CreateHero(name);
            heroBilder.SetHealth();
            heroBilder.SetMana();
            heroBilder.SetStamina();
            heroBilder.SetStrength();
            heroBilder.SetIntelligence();
            heroBilder.SetAgility();
            heroBilder.SetTalents();
            return heroBilder.Hero;
        }
    }
}
