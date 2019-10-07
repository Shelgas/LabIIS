using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            a.setDriver("Ner'zhul");
            Car b = new Car();
            b.setDriver("Lesko");
            Console.WriteLine(a.driver.Name);
            Console.WriteLine(b.driver.Name);
            Console.ReadLine();
        }
    }
}
