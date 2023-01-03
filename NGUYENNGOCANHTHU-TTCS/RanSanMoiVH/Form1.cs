using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RanSanMoiVH
{
    public partial class Form1 : Form
    {
        int diem = 0;
        Random randThucan = new Random();
        Thucan thucan;
        Tuong tuong;
        Vatcan Vatcan;
        Graphics paper;
        Ran ran = new Ran();
        // khoi tao cac phim dieu khien ran
        Boolean trai = false, phai = false, len = false, xuong = false;
        public Form1()
        {
            InitializeComponent();
            thucan = new Thucan(randThucan);
            tuong = new Tuong();
            Vatcan = new Vatcan();
        }
        // hien thi do hoa tren form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lbtocdo1.Text =(250 - timer1.Interval).ToString();
            paper = e.Graphics;
            Vatcan.veVatcan(paper);
            thucan.vethucan(paper);
            ran.drawran(paper);
            tuong.vetuong(paper);
        }
        // khoi tao su kien tren ban phim
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData ==Keys.F2)
            {
                timer1.Enabled = true;
                trai = false; phai = false; len = false; xuong = false;
                label1.Text = "";
            }
            if (e.KeyData == Keys.Up && xuong == false)
            {
                len = true;
                xuong = false;
                trai = false;
                phai = false;
            }
            if (e.KeyData == Keys.Down && len == false)
            {
                len = false;
                xuong = true;
                trai = false;
                phai = false;
            }
            if (e.KeyData == Keys.Left && phai == false)
            {
                len = false;
                xuong = false;
                trai = true;
                phai = false;
            }
            if (e.KeyData == Keys.Right & trai == false)
            {
                len = false;
                xuong = false;
                trai = false;
                phai = true;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusdiem.Text = diem.ToString();
            if (xuong == true)
            {
                ran.dichuyenxuong();
            }
            if (len == true)
            {
                ran.dichuyenlen();
            }
            if(trai == true)
            {
                ran.dichuyentrai();
            }
            if (phai == true)
            {
                ran.dichuyenphai();
            }
            if (thucan.thucanRec.IntersectsWith(Vatcan.VatcanRec))
            {
                thucan.thucanLocation(randThucan);
            }
            if (thucan.thucanRec.IntersectsWith(Vatcan.VatcanRec1))
            {
                thucan.thucanLocation(randThucan);
            }
            if (thucan.thucanRec.IntersectsWith(Vatcan.VatcanRec2))
            {
                thucan.thucanLocation(randThucan);
            }
            if (thucan.thucanRec.IntersectsWith(Vatcan.VatcanRec3))
            {
                thucan.thucanLocation(randThucan);
            }
            for (int i = 0; i < ran.RanRec.Length; i++)
            {
                if (ran.RanRec[i].IntersectsWith(thucan.thucanRec))
                {
                    timer1.Interval -= 5;
                    diem += 10;
                    ran.growran();
                    thucan.thucanLocation(randThucan);
                }
            }
            vacham();
            //cap nhat lai man hinh
            this.Invalidate();
        }
        //ham va cham chet
        public void vacham()
        {
            for (int i = 1; i < ran.RanRec.Length; i++)
            {
                if (timer1.Interval == 5)
                {
                    MessageBox.Show("Bạn Đã Chiến Thắng");
                    ran = new Ran();
                }
                if(ran.RanRec[0].IntersectsWith(ran.RanRec[i]))
                {
                    Restart();
                }
                if (ran.RanRec[0].IntersectsWith(Vatcan.VatcanRec))
                {
                    Restart();
                }
                if (ran.RanRec[0].IntersectsWith(Vatcan.VatcanRec1))
                {
                    Restart();
                }
                if (ran.RanRec[0].IntersectsWith(Vatcan.VatcanRec2))
                {
                    Restart();
                }
                if (ran.RanRec[0].IntersectsWith(Vatcan.VatcanRec3))
                {
                    Restart();
                }
                if(ran.RanRec[0].X<10||ran.RanRec[0].X>400)
                {
                    Restart();
                }
                if (ran.RanRec[0].Y < 10 || ran.RanRec[0].Y > 400)
                {
                    Restart();
                }
            }
        }
        void Restart()
        {
            this.Close();
            timer1.Enabled = false;
            toolStripStatusdiem.Text = "0";
            diem = 0;
            label1.Text = "Nhấn F2 Để Bắt Đầu Chơi";
            MessageBox.Show("Rắn Của Bạn Đã Chết Nhấn OK và chơi lại");
            ran = new Ran();
        }

        public Graphics h { get; set; }

        public Random randvatcan { get; set; }

        public Random randVatcan { get; set; }
        private void timerchuchay_Tick(object sender, EventArgs e)
        {
            lblChuoichu.Location = new Point(lblChuoichu.Location.X, lblChuoichu.Location.Y - 1);
            if (lblChuoichu.Location.Y + lblChuoichu.Height < 0)
            {
                lblChuoichu.Location = new Point(lblChuoichu.Location.X,pnchuchay.Height);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblChuoichu.Text = "  \n****thực tập cơ sở****  \n ***Trò Chơi Rắn Săn Mồi***\nTrường Đại Hoc NHA TRANG \nSinh Viên Thực Hiện: \n+ Họ Và Tên: NGUYỄN NGỌC ANH THƯ \n+ Lớp: 62.CNTT-1\n+ MSV: 62132986 \nSử dụng các phím điều hướng \nDi chuyển để điều khiển rắn \nTheo hướng của phím Di chuyển \nKhéo léo điều khiển sao cho \nKhông được va vào tường và vật cản  \nVà Ăn thức ăn \n với mỗi lần ăn thức ăn \nSẽ được 10 điểm\n Và Tốc độ sẽ Tăng thêm 5km/h";
        }

        private void chơiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            toolStripStatusdiem.Text = "0";
            diem = 0;
            ran = new Ran();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTin form = new FormThongTin();
            form.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHuongdan form = new FormHuongdan();
            form.Show();
        }
   }

}
