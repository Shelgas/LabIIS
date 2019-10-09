using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaSecond
{
    class Oserver : IObserver
    {
        public string Name { get; private set; }
        public Oserver(string name)
        {
            Name = name;
        }

        public void Update(IObserver observer)
        {
           Console.WriteLine("{0} значение получено.", observer.Name); 
        }
    }
}
