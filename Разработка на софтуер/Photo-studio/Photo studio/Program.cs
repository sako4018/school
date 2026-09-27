

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_studio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Presentation presentation = new Presentation();
            presentation.Present();
            //
            Console.ReadKey();
        }
    }
}
