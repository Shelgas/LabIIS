using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaSecond
{
    interface IObserver
    {
        string Name { get; }
        void Update(IObserver observer);
    }
}
