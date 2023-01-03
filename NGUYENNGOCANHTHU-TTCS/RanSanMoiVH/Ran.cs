using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace RanSanMoiVH
{
    class Ran
    {
        /// <summary>
        /// Khoi tao mang
        /// </summary>
        private Rectangle[] ranRec;
        public Rectangle[] RanRec
            {
                get 
                {
                    return ranRec;
                }

            }
        private SolidBrush brush;
        private SolidBrush brush2;
        private int x, y, width, height;
        /// <summary>
        /// Hàm khởi tạo con rắn
        /// </summary>

        public Ran()
        {
            // khoi tao chieu dai con ran
            ranRec = new Rectangle[3];
            // tao moi co ve voi mau xanh
            brush = new SolidBrush(Color.Green);
            //tao moi co ve cho dau con ran
            brush2 = new SolidBrush(Color.Red);
            // truyen toa do con ran
            x = 30;
            y = 10;
            width = 9;
            height = 9;
            // sap xep dot cua con ran
            for (int i = 0; i < ranRec.Length; i++)
            {
                ranRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
          }

        /// <summary>
        /// ve va to mau cho ran
        /// </summary>
        /// <param name="paper"></param>
        public void drawran(Graphics paper)
        {
            foreach (Rectangle rec in ranRec)
            {
                //to mau cho ran
                paper.FillRectangle(brush, rec);
                //to mau dau ran
                paper.FillRectangle(brush2,ranRec[0]);
            }
        }
        // ve ham di chuyen
        public void veRanChay()
        {
            for (int i = RanRec.Length - 1 ; i > 0; i--)
            {
                ranRec[i] = RanRec[i - 1];
            }
        }
        //ran lon
        public void growran()
        {
            List<Rectangle> rec = ranRec.ToList();
            rec.Add(new Rectangle(ranRec[ranRec.Length - 1].X, ranRec[ranRec.Length - 1].Y, width, height));
            ranRec = rec.ToArray();
        }
        //ve ham di chuyen
        public void dichuyenxuong()
        {
            veRanChay();
            ranRec[0].Y += 10;
        }
        public void dichuyenlen()
        {
            veRanChay();
            ranRec[0].Y -= 10;
        }
        public void dichuyentrai()
        {
            veRanChay();
            ranRec[0].X -= 10;
        }
        public void dichuyenphai()
        {
            veRanChay();
            ranRec[0].X += 10;
        }
    }
}
