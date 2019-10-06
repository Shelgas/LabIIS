using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaNumberOne
{
    public class WayStrategy
    {
        public IMeans means { get; set; }

        public WayStrategy(IMeans means)
        {
            this.means = means;
        }

        public string Time()
        {
            return means.Time();
        }

        public string Pay()
        {
            return means.Pay();
        }

    }
}
