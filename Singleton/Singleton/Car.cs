using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Car
    {
        public Driver driver { get; set; }

        public void setDriver(string name)
        {
            driver = Driver.getInstance(name);
        }


        public void OutDriver()
        {
            Driver.OutInstance();
        }
    }
}
