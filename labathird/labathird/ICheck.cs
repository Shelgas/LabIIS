using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    interface ICheck
    {
        ICheck SetNext(ICheck handler);

        void Check(Hero request, IMonster monster);
    }
}
