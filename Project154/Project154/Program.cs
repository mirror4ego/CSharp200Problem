﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project154
{
    class Program
    {
        static void Main(string[] args)
        {
            int tray = 3;
            Hanoi hanoi = new Hanoi(tray);
            hanoi.show();
        }
    }
}
