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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < 60; i++)

            {
                comboBoxMinute.Items.Add(i);
            }
            for (int i = 0; i < 24; i++)

            {
                comboBoxHour.Items.Add(i);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            
        }

        private void labelZero_Click(object sender, EventArgs e)
        {
            
            
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                labelHour.Text = DateTime.Now.Hour.ToString("00");
                labelMinute.Text = DateTime.Now.Minute.ToString("00");
                   
                
            }
            
            if ( labelHour.Text == comboBoxHour.Text && labelMinute.Text == comboBoxMinute.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("ALARM OÇÇ");
                axWindowsMediaPlayer1.URL = @"C:\Users\Adm\Desktop\adayatthecourt.mp3";
            }
        }
        
        public void textBoxAlarm_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboBoxHour_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < 24; i++)

            {
                comboBoxHour.Items.Add(i);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            
        }
        private void comboBoxMinute_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)

            {
                comboBoxMinute.Items.Add(i);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
