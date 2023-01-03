using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RanSanMoiVH
{
    class Vatcan
    {
        private int x, y,x1,y1,x2,y2,x3,y3, width, height;
        private SolidBrush brush2;
        public Rectangle VatcanRec;
        public Rectangle VatcanRec1;
        public Rectangle VatcanRec2;
        public Rectangle VatcanRec3;
        public void veVatcan(Graphics paper)
        {
            width = 180;
            height = 20;
            VatcanRec.X = x;
            VatcanRec.Y= y;
            x = 30;
            y = 30;
            VatcanRec1.X = x1;
            VatcanRec1.Y = y1;
            x1 = 200;
            y1 = 100;
            VatcanRec2.X = x2;
            VatcanRec2.Y = y2;
            x2 = 30;
            y2 = 200;
            VatcanRec3.X = x3;
            VatcanRec3.Y = y3;
            x3 = 200;
            y3 = 300;
            VatcanRec = new Rectangle(x, y, width, height);
            brush2 = new SolidBrush(Color.Violet);
            paper.FillRectangle(brush2,VatcanRec);
            VatcanRec1 = new Rectangle(x1, y1, width, height);
            paper.FillRectangle(brush2, VatcanRec1);
            VatcanRec2 = new Rectangle(x2, y2, width, height);
            paper.FillRectangle(brush2, VatcanRec2);
            VatcanRec3 = new Rectangle(x3, y3, width, height);
            paper.FillRectangle(brush2, VatcanRec3);

        }

    }
}
