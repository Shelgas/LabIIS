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
            Console.WriteLine(a.driver.Name);

            a.setDriver("Lesko");
            Console.WriteLine(a.driver.Name);

            a.OutDriver();
            a.setDriver("Lesko");
            Console.WriteLine(a.driver.Name);

            Console.ReadLine();
        }
    }
}
