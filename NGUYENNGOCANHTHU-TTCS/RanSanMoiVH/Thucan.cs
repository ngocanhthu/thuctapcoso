using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RanSanMoiVH
{
    class Thucan
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle thucanRec;
        public Thucan(Random randThucan)
        {
            x = randThucan.Next(1, 40) * 10;
            y = randThucan.Next(1, 40) * 10;
            brush = new SolidBrush(Color.Red);
            width = 9; height = 9;
            thucanRec = new Rectangle(x,y,width,height);
        }
        public void thucanLocation(Random randThucan)
        {
            x = randThucan.Next(1, 40) * 10;
            y = randThucan.Next(1, 40) * 10;
        }
        public void vethucan(Graphics paper)
        {
            thucanRec.X = x;
            thucanRec.Y = y;
            paper.FillRectangle(brush,thucanRec);
        }

    }
}
