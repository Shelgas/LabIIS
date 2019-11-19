using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    abstract class HeroBilder
    {
        public Hero Hero { get; private set; }
        public void CreateHero(string name)
        {
            Hero = new Hero(name);
        }

        public abstract ITalents ChoiceTalents();

        public abstract void SetHealth();
        public abstract void SetMana();
        public abstract void SetStamina();
        public abstract void SetStrength();
        public abstract void SetIntelligence();
        public abstract void SetAgility();

        public abstract void SetTalents();
    }
}
