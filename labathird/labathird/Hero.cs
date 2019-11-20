using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class Hero
    {
        public string Name { get; private set; }

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }


        public string FirstAbility { get; set; }

        public string SecondAbility { get; set; }

        public string ThirdAbility { get; set; }

        public string GetCharacteristics()
        {
           return $"Имя: {Name}  Здоровье: {Health}  Мана: {Mana} " +
                $"Выносливость: {Stamina} Сила: {Strength}" +
                $" Интелект: {Intelligence} Ловкость: {Agility}";
        }

        

        public Hero(string name)
        {
            Name = name;
        }

    }
}
