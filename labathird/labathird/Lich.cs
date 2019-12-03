using System;


namespace labathird
{
    class Lich : IMonster
    {

        public int Health { get; set; }

        public int Mana { get; set; }
        
        public int Strength { get; set; }

        private static string Image = @" __         __
 / /         \ \
/ / -\-----/- \ \
| \/  \   /  \/ |
| /    \ /    \ |
\/ __   /   __ \/
/ /  \     /  \ \
| |   \   /   | |
| | . | _ | . | |
| \___// \\___/ |
 \     \_/     /
  \___     ___/
   \ \     / /
    \ vvvvv /
    | (   ) |
    | ^^^^^ |
    \_______/";

        public Lich(Hero hero)
        {
            Health = 200;
            Strength = 100;
            Mana = 100;
            Checks healthCheck = new HealthCheck();
            Checks manaCheck = new ManaCheck();
            Checks strengthCheck = new SrengthCheck();

            healthCheck.SetNext(manaCheck).SetNext(strengthCheck);

            healthCheck.Check(hero, this);
            Greetings();
            ShowImage(Image);
            ShowСharacteristics(Health, Mana, Strength);
            
        }


        public static void Greetings()
        {
            Console.WriteLine();

            Console.WriteLine("How do you do, fellow kids?");
        }

        public static void ShowImage(string image)
        {
            Console.WriteLine(image);
        }

        public static void ShowСharacteristics(int health, int mana, int strength)
        {
            Console.WriteLine($"Health: {health}  Mana: {mana} Strength: {strength}");
            Console.WriteLine();
        }


        public int Attack()
        {
            return Strength;
        }

    }


    class HealthCheck : Checks
    {
        public override void Check(Hero hero, IMonster monster)
        {
            if (hero.Health > 200)
            {
                Console.WriteLine("What's cooking, good looking");
                hero.Health /= 200;
            }
            else base.Check(hero, monster);
        }
    }

    class ManaCheck : Checks
    {
        public override void Check(Hero hero, IMonster monster)
        {
            if (hero.Mana >= 100)
            {
                Console.WriteLine("You are not prepared");
                 monster.Mana = hero.Mana*2;
            }
            else base.Check(hero, monster);
        }
    }


    class SrengthCheck : Checks
    {
        public override void Check(Hero hero, IMonster monster)
        {
            if (hero.Strength >= 80)
            {
                Console.WriteLine("I am give up");
                monster.Health = 0;
            }
            else base.Check(hero, monster);
        }
    }

}
