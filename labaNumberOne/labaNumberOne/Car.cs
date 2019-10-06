using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaNumberOne
{
    public class Car : IMeans
    {
        public string Time()
        {
            // Console.WriteLine();
            return "2 hours";
        }

        public string Pay()
        {
            return "500 gold";
        }
    }
}
