using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class CellVisual : Label
    {
        public int PositionX { get; }
        public int PositionY { get; }
        public CellVisual(int x, int y) 
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
