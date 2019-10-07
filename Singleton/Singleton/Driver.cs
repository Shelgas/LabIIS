using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Driver
    {
        private static object locker = new object();
        private static Driver instance;

        public string Name { get; private set; }

        protected Driver(string name)
        {
            Name = name;
        }

        public static Driver getInstance(string name)
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new Driver(name);
                }
            }
            return instance;
        }

    }
}
