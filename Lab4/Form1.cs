﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        delegate void ShowMessage(string m);

        ShowMessage myDelegate = (s) => {  };

        public Form1()
        {
            InitializeComponent();
        }

        public void ShowA(string m)
        {
            MessageBox.Show("DELEGATE A " + m);
        }
        public void ShowB(string m)
        {
            MessageBox.Show("DELEGATE B " + m);
        }

        private void buttonDeleteDelA_Click(object sender, EventArgs e)
        {
            myDelegate -= ShowA;
        }

        private void buttonAddDelA_Click(object sender, EventArgs e)
        {
            myDelegate += ShowA;
        }

        private void buttonAddDelB_Click(object sender, EventArgs e)
        {
            myDelegate += ShowB;
        }

        private void buttonDeleteDelB_Click(object sender, EventArgs e)
        {
            myDelegate -= ShowB;
        }

        private void buttonInvokeDelegate_Click(object sender, EventArgs e)
        {
            myDelegate("Hallå alla delagater!");
        }
    }
}
