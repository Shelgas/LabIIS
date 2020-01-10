using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class Skeleton : IMonster
    {
        public int Health { get; set; }

        public int Mana { get; set; }

        public int Strength { get; set; }

        private static string Image = @"      .-.
     (o.o)
      |=|
     __|__
   //.=|=.\\
  // .=|=. \\
  \\ .=|=. //
   \\(_=_)//
    (:| |:)
     || ||
     () ()
     || ||
     || ||
    ==' '==";

        public Skeleton()
        {
            Health = 100;
            Strength = 10;
            Mana = 0;
            Greetings();
            Lich.ShowImage(Image);
            ShowСharacteristics(Health, Mana, Strength);
        }

        public void Greetings()
        {
            Lich.Greetings();
        }

        public static void ShowСharacteristics(int health, int mana, int strength)
        {
            Lich.ShowСharacteristics(health, mana, strength);
        }

        public int Attack()
        {
            return Strength;
        }
    }
}
