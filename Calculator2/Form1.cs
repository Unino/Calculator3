﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation cal = new Calculator2.Calculation(a,b);
            txtKQ.Text = cal.Execute("+").ToString();
            //if (txtA.Text != String.Empty && txtB.Text != String.Empty)

            //{
            //    double a = double.Parse(txtA.Text);
            //    double b = double.Parse(txtB.Text);
            //    double c = a + b;
            //    txtKQ.Text = c.ToString(); 
            //}
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtKQ.Text = c.ToString();
        }
    }
}
