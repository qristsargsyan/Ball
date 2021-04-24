using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class Form1 : Form
    {
        int x = 749;
        int y = 483;

        int vx = 5, vy = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Timer.Start();
            start.Enabled = false;
            stop.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            start.Enabled = true;
            stop.Enabled = false;
        }      

        private void Timer_Tick(object sender, EventArgs e)
        {
            Ball.Left = Ball.Left + vx;
            Ball.Top = Ball.Top + vy;

            if (Ball.Left > x || Ball.Left <= 0)
            {
                vx *= -1;
            }
            if (Ball.Top > y || Ball.Top <= 0)
            {
                vy *= -1;
                vy -= 2;
            }

        }
    }
}
