using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SpirinAA.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x >= 3) && (x <= 5) && (y >= 3) && (y <= 5)) || ((x >= 5) && (x <= 11) && (y == 4)) || ((x == 11) && (y == 3)) || ((x == 11) && (y == 5)) || ((x == 6) && (y == 7)) || ((x >= 9) && (x <= 11) && (y == 6)) || ((x >= 9) && (x <= 12) && (y == 7)) || ((x >= 5) && (x <= 12) && (y == 8)) || ((x == 12) && (y >= 9) && (y <= 10)) || ((x >= 3) && (x <= 11) && (y >= 9) && (y <= 12)) || ((x >= 6) && (x <= 8) && (y == 13)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
