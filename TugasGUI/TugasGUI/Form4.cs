﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 GUI1 = new Form1();
            GUI1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 GUI2 = new();
            GUI2.Show();
        }
    }
}
