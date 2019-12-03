using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    interface IMonster
    {
        int Mana { get; set; }
        int Health { get; set; }
        int Strength { get; set; }
    
        int Attack();

    }
}
