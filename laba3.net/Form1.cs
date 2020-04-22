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
        Random r = new Random();

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
            int seed = 0;
            Straight straight = new Straight();
            straight = new Straight();
            straight.getPoints(seed++);
            straight.getCoefficient();
           // straight.getCoefficientB();
            /* if (straight.checkParallel() == true)
                 info += "Straight lines are parallel\n";
             else
                 info += $"The angle between the lines = {straight.getAngle()}\n";
             */
            checkLineBox.Text += straight.showInfo();

        }


    }
}
