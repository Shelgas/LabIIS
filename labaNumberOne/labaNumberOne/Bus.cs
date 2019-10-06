using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaNumberOne
{
    public class Bus : IMeans
    {

        public string Time()
        {
            // Console.WriteLine();
            return "4 hours";
        }

        public string Pay()
        {
            return "200 gold";
        }
    }
}
