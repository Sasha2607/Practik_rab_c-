﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label1.MaximumSize = new Size(1360, 760);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
           this.Hide();

        
          
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         //   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         //   this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
