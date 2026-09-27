using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation_3layers
{
    internal class PresentationLayer
    {
        static void Main(string[] args)
        {   
            //въвеждаш данни
            Console.Write("Enter the km you want to travel: ");
            decimal km = Convert.ToDecimal(Console.ReadLine());
            string dn = "";
            if (km < 20)
            {
                Console.Write("day or night: ");
                dn = Console.ReadLine();
            }
            //връща обработената цена
            BuisnessLayer buisnessLayer = new BuisnessLayer();
            double price = buisnessLayer.CalculatePrice(km, dn);
            Console.WriteLine(price + " lv.");

            //
            Console.ReadKey();
        }
    }
}