﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0524
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = +10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -10;
            vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = +10;
            vy = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(257,145);
            vx = 0;
            vy = 0;
        }
    }
}
