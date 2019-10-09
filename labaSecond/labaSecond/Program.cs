using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            BFS raid = new BFS();
            foreach (var item in new List<string> { "Shelgas", "Tianid", "Rainel", "Shedor" })
            {
                Oserver plyer = new Oserver(item);
                raid.Attach(plyer);
            }
            raid.Notify();
            Console.ReadLine();

        }
    }
}
