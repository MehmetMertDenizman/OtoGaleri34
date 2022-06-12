using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C9Timer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            timer12.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void labelHour_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timer12.Enabled)
            {
                labelTimer.Text = DateTime.Now.Second.ToString();
                labelMinute.Text = DateTime.Now.Minute.ToString();
                labelHour.Text = DateTime.Now.Hour.ToString();
            }
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

      

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            Form2 goform2 = new Form2();
            goform2.Show();
            this.Hide();

        }
    }
}
