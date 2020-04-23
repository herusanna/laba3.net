using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3.net
{
    public partial class Form1 : Form
    {
        int seed = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            Straight s1 = new Straight(seed++);
            Straight s2 = new Straight(seed++);           
            checkLineBox.Text = s1.showInfo();
            checkLineBox.Text = s2.showInfo();
            double angle = s1 % s2;
            if (s2.K1 == s2.K2)
            {
                checkLineBox.Text += "The lines are parallel\n";
            }
            else if (s2.K1 != s2.K2)
            {
                checkLineBox.Text += "The lines are not parallel\n";
                checkLineBox.Text += $"The angle between the lines: {angle}\n";               
            }
        }
    }
}