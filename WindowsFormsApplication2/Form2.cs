﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            label1.Text = "Loading..." + progressBar1.Value + "%";

            if (progressBar1.Value == 100)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
                timer1.Stop();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
    }
}
