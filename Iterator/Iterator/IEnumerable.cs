using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IEnumerable<T>
    {
        IIterator<T> GetIterator();
        
        Beer this[int index] { get; }

        int Count { get; }
    }
}
