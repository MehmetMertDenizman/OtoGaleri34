using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C8WebBrowser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonRez_Click(object sender, EventArgs e)
        {
            Form2 rez = new Form2();
            rez.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://cdn.powergroup.com.tr/powerpop/podcast/2022/04/27/1/-/1-popmix-1651088637.mp3";
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            
            if(groupBoxRadio.Visible == true)
            {
                groupBoxRadio.Visible = false;
            }
            else
            {
                groupBoxRadio.Visible = true;
            }
        }
    }
}
