﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SpirinAA.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 46 == y;
            res[1] = x != y;
            res[2] = x - 47 < y;
            res[3] = x - 50 > y;
            res[4] = x <= y;
            res[5] = y >= x;

            return res;
        }
    }
}
