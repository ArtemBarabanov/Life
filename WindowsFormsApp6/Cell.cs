﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Cell
    {
        public int X { get; }
        public int Y { get; }
        public bool IsAlive { get; set; }

        public Cell(int x, int y) 
        {
            X = x;
            Y = y;
        }
    }
}
