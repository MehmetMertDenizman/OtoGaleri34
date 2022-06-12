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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void LbLID_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbxID.Text == "admin" && txtbxPW.Text == "anan")
            {
                Form3 seyahat = new Form3();
                seyahat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ibine");
                txtbxID.Clear();
                txtbxPW.Clear();
            }
        }

        private void txtbxPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
