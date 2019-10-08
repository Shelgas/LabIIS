using System;
using System.Threading;

namespace Observer
{
    class Player : IObserver
    {

        public string Name { get; private set; }
        public int Health { get; private set; } 

        public Player(string name)
        {
            Name = name;
            Health = new Random().Next(0, 100);
            Thread.Sleep(15);
        }

        public void Update(IObserver observer)
        {
            if (observer.Health < 30)
            {
                Console.WriteLine("{0} пьёт поушены.", observer.Name);
            }
        }
    }
}
