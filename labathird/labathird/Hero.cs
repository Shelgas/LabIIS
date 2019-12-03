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

        public string[] Image { private get; set; }

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
           return $"Name: {Name}  Health: {Health}  Mana: {Mana} " +
                $"Stamina: {Stamina} Strength: {Strength}" +
                $" Intelligence: {Intelligence} Agility: {Agility}";
        }

        

        public void ShowImage()
        {
            foreach (var line in Image)
            {
                Console.WriteLine(line);
            }

        }

        public int Attack()
        {
            return Strength;
        }


        public Hero(string name)
        {
            Name = name;
        }

    }
}
