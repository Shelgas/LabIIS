using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Raid : ISubject
    {
        private List<IObserver> raid_list = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            raid_list.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            raid_list.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Босс впадает в Энрейдж");
            foreach (var observer in raid_list)
            {
                observer.Update(observer);
            }
        }
    }
}
