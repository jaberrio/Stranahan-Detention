﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class LogOn : Form
    {
        public long authenKey;

        public LogOn()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
            
            
        }

        private void label1_Click(object sender , EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender , EventArgs e)
        {

        }

        private void checkServerStatues(object sender , EventArgs e)
        {
            Console.WriteLine(Support.checkAllServerStat());
        }
    }
}
