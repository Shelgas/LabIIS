using System;


namespace labathird
{
    class WarriorBilder : HeroBilder
    {
        public override void SetAgility()
        {
            Hero.Agility = 50;
        }

        public override void SetHealth()
        {
           Hero.Health = 500;
        }

        public override void SetIntelligence()
        {
            Hero.Intelligence = 10;
        }

        public override void SetMana()
        {
            Hero.Mana = 0;
        }

        public override void SetStamina()
        {
            Hero.Stamina = 100;
        }

        public override void SetStrength()
        {
           Hero.Strength = 100;
        }


        public override ITalents ChoiceTalents()
        {
            return new ArmsWar();
        }

        public override void SetTalents()
        {
            var spec = ChoiceTalents();
            Hero.FirstAbility = spec.SetFirstAbility();
            Hero.SecondAbility = spec.SetSecondAbility();
            Hero.ThirdAbility = spec.SetThirdAbility();
        }

        public override void SetImage()
        {
            Hero.Image = new[]
            {
                @"                                .-'`-.
                               /  | | \
                              /   | |  \
                             |  __|_|___|
                             |' |||
                             |(   _L   ||
                             \|`-'__`-'|'
                              |  `--'  |
                             _|        |-.
                         .-'| |  \     /  `-.
                        /   | |\     .'      `-.
                       /    | | `''''           \
                      J     | |             _____|
                      |  |  J J         .-'   ___ `-.
                      |  \   L L      .'  .-'  |  `-.`.
                      | \|   | |     /  .'|    |    |\ \
                      |  |   J J   .' .'  |    |    | \ \
                      |  |    L L J  /    |    |    |  \ L
                     /   |     \ \F J|    |    |    |   LJ
                     |   |      \J F | () | () | () | ()| L
                    J  \ |       FJ  |    |  / _`-. |   J |
                    |    |      J |  |    | //    \ |   J |
                   J     |\     | |  |    ||:(     ||   J |
                   |     | `----| |  |    ||::`._.:||   | F
                   |     /\_    | |  |    ||:::::::F|   | F
                   |    |  /`---| |  |    | \:::::/ |   FJ
                   F    |  / |  J |  |    |  `-:-'  |  J F
                  J_.--/  /  |  J J  | () | () | () |()FJ
                   |  |    /     L L |    |    |    | / F
                   |  |     |    \ \ |    |    |    |/ /
                 |`-. |    |     |\ \|    |    |    / /
                 J'\ \|    |     | `.`.   |    |  .'.'
                / .'> |    |     |  `-.`-.|____.-'.'
              .' /::'_|    |/    |    `-.______.-'
             / .::/   \    |     |           |  |
           .' /::'     |--._     |           |--|
          / .::/       |    `-.__|     ____.-|//|
        .' /::'        |        F `--'      ||< |
       / .::/          |       J   |        FL\\|
     .' /::'           )       |   |        F| >|
    / .::/            (        \   |        F|//|
  .' /::'              \       /   |        F|--|
 / .::/                 |` `' '(   (      ' J|  |
| /::'                  |  | ` \   \  `    / J  |
|_:/                    |  | | |    |`-  ''F J  J
                        |    ' F    |   "" |  `-'
                        |     J     |      |
                        |     /     |      |
                        |   .'      |      F
                       /---'(       J     J
                     .'     \        L    |
                  .-'        )       L    F
                .'       .---'       \__.-'
               (       .'             L   |
                `-----'               |   \
                                      J    \
                                       L    L
                                       |    F
                                       `-.-'"
            };
        }
    }
}
