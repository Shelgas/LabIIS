using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Refrigerator : IEnumerable<Beer>
    {

        private Beer[] beers;

        public Refrigerator()
        {
            beers = new Beer[]
                {
                    new Beer {Name = "Kozzel"},
                    new Beer {Name = "Bud"},
                    new Beer {Name = "Guinness"}
                };
        }

        public int Count
        {
            get { return beers.Length; }
        }

        public IIterator<Beer> GetIterator()
        {
            return new RefrigeratorNumerator(this);
        }

        public Beer this[int index]
        {
            get { return beers[index]; }
        }

    }
}
