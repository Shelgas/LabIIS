using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Raid raid = new Raid();
            foreach (var item in new List<string> { "Shelgas", "Tianid", "Rainel", "Shedor" })
            {
                Player plyer = new Player(item);
                raid.Attach(plyer);
            }
            raid.Notify();
            Console.ReadLine();
        }
    }
}
