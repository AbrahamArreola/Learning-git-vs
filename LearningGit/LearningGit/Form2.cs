using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            Form1 mainWindow = Owner as Form1;
            mainWindow.textField.Text = msgText.Text;
            this.Close();
        }
    }
}
