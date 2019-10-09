using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaSecond
{
    interface IIterator
    {
        bool HasMoveNext();
        int Next();    
    }
}
