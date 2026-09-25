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
                int perPic = standart == 2 ? dal.BasicHighTime() : dal.BasicStandartTime();
                return dal.BasicStartTime() + numOfPic * perPic;
            }
            else if (numOfPic >= 20 && numOfPic < 100)
            {
                return dal.PackageTime() * numOfPic;
            }
            else
            {
                return numOfPic * dal.ParallelTime();
            }
        }
    }
}