﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string msg = textField.Text;
            textField.Text += msg;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Form2 newWindow = new Form2();
            AddOwnedForm(newWindow);
            newWindow.ShowDialog();
        }
    }
}
