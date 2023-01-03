using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RanSanMoiVH
{
    public partial class FormMuc : Form
    {
        public FormMuc()
        {
            InitializeComponent();
        }

        private void btde_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            form.timer1.Interval = 200;
        }

        private void btvua_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            form.timer1.Interval = 150;
        }

        private void btkho_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            form.timer1.Interval = 100;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
