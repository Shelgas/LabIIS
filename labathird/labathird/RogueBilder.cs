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
            return new AssassRog();
        }

        public override void SetAgility()
        {
            Hero.Agility = 100;
        }

        public override void SetHealth()
        {
            Hero.Health = 350;
        }

        public override void SetImage()
        {
            Hero.Image = new[]
            {
                @"                                                      ____
                                                     /    `.
                                                    /-----.|          ____
                                                ___/___.---`--.__.---'    `--.
                                  _______.-----'           __.--'             )
                              ,--'---.______________..----'(  __         __.-'
                                        `---.___,-.|(a (a) /-'  )___.---'
                                                `-.>------<__.-'
            ______                       _____..--'      //
    __.----'      `---._                `._.--._______.-'/))
,--'---.__              -_                  _.-(`-.____.'// \
          `-._            `---.________.---'    >\      /<   \
              \_             `--.___            \ \-__-/ /    \
                \_                  `----._______\ \  / /__    \
                  \                      /  |,-------'-'\  `-.__\
                   \                    (   ||            \      )
                    `\                   \  ||            /\    /
                      \                   >-||  @)    @) /\    /
                      \                  ((_||           \ \_.'|
                       \                    ||            `-'  |
                       \                    ||             /   |
                        \                   ||            (   '|
                        \                   ||  @)     @)  \   |
                         \                  ||              \  )
                          `\_               `|__         ____\ |
                             \_               | ``----'''     \|
                               \_              \    .--___    |)
                                 `-.__          \   |     \   |
                                      `----.___  \^/|      \/\|
                                               `--\ \-._  / | |  
                                                   \ \  `'  \ \
                                            __...--'  )     (  `-._
                                           (_        /       `.    `-.__
                                             `--.__.'          `.       )
                                                                 `.__.-'
"
            }; 
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
            var spec = ChoiceTalents();
            Hero.FirstAbility = spec.SetFirstAbility();
            Hero.SecondAbility = spec.SetSecondAbility();
            Hero.ThirdAbility = spec.SetThirdAbility();
        }
    }
}
