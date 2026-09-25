using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Photo_studio
{
    internal class Presentation
    {
        public void Present()
        {
            Console.WriteLine("Enter number of pictures: ");
            int numOfPic = Convert.ToInt32(Console.ReadLine());
            if (numOfPic <= 0 || numOfPic > 5000)
            {
                Console.WriteLine("Invalid number of pictures.");
                return;
            }
            else
            {
                Console.WriteLine("Enter standard (1 for basic, 2 for high): ");
                int standart = Convert.ToInt32(Console.ReadLine());
                if (standart != 1 && standart != 2)
                {
                    Console.WriteLine("Invalid standard.");
                    return;
                }
                Business business = new Business();
                int totalTime = business.CalculateTime(standart, numOfPic);
                Console.WriteLine($"Total time for {numOfPic} pictures: {totalTime} seconds.");
            }
        }
    }
}
