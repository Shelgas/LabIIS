using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class FrostMage : ITalents
    {
        public string SetFirstAbility()
        {
            return "Frostbolt";
        }

        public string SetSecondAbility()
        {
            return "Ice Lance";
        }

        public string SetThirdAbility()
        {
            return "Blizzard";
        }
    }
   
}
