using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class RefrigeratorNumerator : IIterator<Beer>
    {
        IEnumerable<Beer> aggregate;
        int index = 0;


        public RefrigeratorNumerator(IEnumerable<Beer> aggregate)
        {
            this.aggregate = aggregate;
        }


        public bool MoveNext()
        {
            return index < aggregate.Count;
        }

        public Beer Next()
        {
            return aggregate[index++];
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
