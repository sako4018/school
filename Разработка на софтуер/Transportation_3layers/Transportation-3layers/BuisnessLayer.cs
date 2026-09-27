using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Transportation_3layers
{
    internal class BuisnessLayer
    {
        private DAL dal = new DAL();
        public double CalculatePrice(decimal km, string dn)
        {
            //създаваме променлива да пази цената
            double price = 0;
            //такси ден/нощ
            if (km < 20)
            {
                if (dn == "day")
                {
                    price = dal.TaxiStartPrice() + ((double)km * dal.GetTaxiDayPrice());
                }
                else if (dn == "night")
                {
                    price = dal.TaxiStartPrice() + ((double)km * dal.GetTaxiNightPrice());
                }
            }
            else if (km >= 20 && km < 100)
            {
                price = (double)km * dal.GetBusPrice();
            }
            else if (km >= 100)
            {
                price = (double)km * dal.GetTrainPrice();
            }
            //връща цената готова сметната
            return price;
        }
    }
}
