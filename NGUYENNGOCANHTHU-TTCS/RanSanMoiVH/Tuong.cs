using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RanSanMoiVH
{
    class Tuong
    {
        public void vetuong(Graphics paper)
        {
            Pen p = new Pen(Color.Black, 10);
            paper.DrawRectangle(p,5, 5, 410, 410);
        }
    }
}
