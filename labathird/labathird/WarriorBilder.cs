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
    }
}
