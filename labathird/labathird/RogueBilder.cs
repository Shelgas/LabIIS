using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class RogueBilder : HeroBilder
    {
        public override ITalents ChoiceTalents()
        {
            throw new NotImplementedException();
        }

        public override void SetAgility()
        {
            Hero.Agility = 100;
        }

        public override void SetHealth()
        {
            Hero.Health = 350;
        }

        public override void SetIntelligence()
        {
            Hero.Intelligence = 70;
        }

        public override void SetMana()
        {
            Hero.Mana = 20;
        }

        public override void SetStamina()
        {
            Hero.Stamina = 100;
        }

        public override void SetStrength()
        {
            Hero.Strength = 70;
        }

        public override void SetTalents()
        {
            throw new NotImplementedException();
        }
    }
}
