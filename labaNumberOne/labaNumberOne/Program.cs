using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaNumberOne
{
    class Program
    {
        static IMeans means = null;

        static void Main(string[] args)
        {
            //Console.WriteLine("Input your chois: ");
            foreach (var item in new List<IMeans> {new Car(), new Legs(), new Bus() })
            {
                means = item;
                 var way = new WayStrategy(means);
                Console.WriteLine(way.Time());
                Console.WriteLine(way.Pay());
            }

            Console.ReadLine();
        }
    }
}
