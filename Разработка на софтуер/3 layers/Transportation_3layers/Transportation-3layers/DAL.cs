using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Transportation_3layers
{
    internal class DAL
    {
        public double GetTaxiDayPrice()
        {
            return 0.79;
        }
        public double GetTaxiNightPrice()
        {
            return 0.90;
        }
        public double GetBusPrice()
        {
            return 0.09;
        }
        public double GetTrainPrice()
        {
            return 0.06;
        }
    }
}
