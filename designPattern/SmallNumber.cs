﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    internal class SmallNumber : INumber
    {
        public int GetNumber(int num)
        {
            return num + num;
        }
    }
}
