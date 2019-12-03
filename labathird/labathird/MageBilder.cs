using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class MageBilder : HeroBilder
    {
        public override ITalents ChoiceTalents()
        {
            return new FrostMage();
        }

        public override void SetAgility()
        {
            Hero.Agility = 20;
        }

        public override void SetHealth()
        {
            Hero.Health = 150;
        }

        public override void SetImage()
        {
            Hero.Image = new[]
            {
                @"                    ____ ",
                @"                  .'* *.'",
                @"               __/_*_*(",
                @"              / _______ \",
                @"             _\_)/___\(_/_ ",
                @"            / _((\- -/))_ \",
                @"            \ \())(-)(()/ /",
                @"             ' \(((()))/ '",
                @"            / ' \)).))/ ' \",
                @"           / _ \ - | - /_  \",
                @"          (   ( .;''';. .'  )",
                @"          _\'__ /    )\ __'/_",
                @"            \/  \   ' /  \/",
                @"             .'  '...' ' )",
                @"              / /  |  \ \",
                @"             / .   .   . \",
                @"            /   .     .   \",
                @"           /   /   |   \   \",
                @"         .'   /    b    '.  '.",
                @"     _.-'    /     Bb     '-. '-._",
                @" _.-'       |      BBb       '-.  '-. ",
                @"(________mrf\____.dBBBb.________)____)"
            }; 
        }

        public override void SetIntelligence()
        {
            Hero.Intelligence = 100;
        }

        public override void SetMana()
        {
            Hero.Mana = 100;
        }

        public override void SetStamina()
        {
            Hero.Stamina = 30;
        }

        public override void SetStrength()
        {
            Hero.Strength = 10;
        }

        public override void SetTalents()
        {
            var spec = ChoiceTalents();
            Hero.FirstAbility = spec.SetFirstAbility();
            Hero.SecondAbility = spec.SetSecondAbility();
            Hero.ThirdAbility = spec.SetThirdAbility();
        }
    }
}
