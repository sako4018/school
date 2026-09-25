using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_studio
{
    internal class Business
    {
        DAL dal = new DAL();

        public int CalculateTime(int standart, int numOfPic)
        {
            if (numOfPic <= 19)
            {
                if (standart == 1)
                {
                    return dal.BasicStartTime() + dal.BasicStandartTime();
                }
                else if (standart == 2)
                {
                    return dal.BasicStartTime() + dal.BasicHighTime();
                }
               
            }
            else
            {
                return dal.BasicStartTime() + dal.BasicStandartTime();
            }
        }
    }
}