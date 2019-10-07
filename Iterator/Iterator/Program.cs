using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator refrigerator = new Refrigerator();
            IIterator<Beer> iterator = refrigerator.GetIterator();
            while (iterator.MoveNext())
            {
                Beer beer = iterator.Next();
                Console.WriteLine(beer.Name);
            }

            Console.ReadLine();
        }
    }
}
