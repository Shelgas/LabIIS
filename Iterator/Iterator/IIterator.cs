using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterator<T>
    {
        bool MoveNext();
        void Reset();
        Beer Next();
    }
}
