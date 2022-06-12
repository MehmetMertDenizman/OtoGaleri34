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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //P==Passenger
        private void btnP1(object sender, EventArgs e)
        {
            
        }
        private void btnP1_1_Click(object sender, EventArgs e)
        {
            listBoxSeat.Items.Add("Seat no 1!");
            listBoxName.Items.Add(textBoxName.Text);
            listBoxSur.Items.Add(textBoxSur.Text);
            listBoxGSM.Items.Add(textBoxGSM.Text);
            listBoxDistrict.Items.Add((object)comboBoxDistrict.Text);
            listBoxTime.Items.Add((object)comboBoxTime.Text);
             


            if (radioMale.Checked == true)
            {
                 
                radioFemale.Checked = false;
                listBoxGender.Items.Add(radioMale.Text);
            }
            
            if (radioFemale.Checked == true)
            {
                radioMale.Checked = false;
                listBoxGender.Items.Add(radioFemale.Text);
            }
            textBoxName.Clear();
            textBoxSur.Clear();
            textBoxGSM.Clear();
            comboBoxDistrict.Text = "";
            comboBoxTime.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            listBoxSeat.Items.Add("Seat no 3!");
            listBoxName.Items.Add(textBoxName.Text);
            listBoxSur.Items.Add(textBoxSur.Text);
            listBoxGSM.Items.Add(textBoxGSM.Text);
            listBoxDistrict.Items.Add((object)comboBoxDistrict.Text);
            listBoxTime.Items.Add((object)comboBoxTime.Text);



            if (radioMale.Checked == true)
            {

                radioFemale.Checked = false;
                listBoxGender.Items.Add(radioMale.Text);
            }

            if (radioFemale.Checked == true)
            {
                radioMale.Checked = false;
                listBoxGender.Items.Add(radioFemale.Text);
            }
            textBoxName.Clear();
            textBoxSur.Clear();
            textBoxGSM.Clear();
            comboBoxDistrict.Text = "";
            comboBoxTime.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            listBoxSeat.Items.Add("Seat no 2!");
            listBoxName.Items.Add(textBoxName.Text);
            listBoxSur.Items.Add(textBoxSur.Text);
            listBoxGSM.Items.Add(textBoxGSM.Text);
            listBoxDistrict.Items.Add((object)comboBoxDistrict.Text);
            listBoxTime.Items.Add((object)comboBoxTime.Text);



            if (radioMale.Checked == true)
            {

                radioFemale.Checked = false;
                listBoxGender.Items.Add(radioMale.Text);
            }

            if (radioFemale.Checked == true)
            {
                radioMale.Checked = false;
                listBoxGender.Items.Add(radioFemale.Text);
            }
            textBoxName.Clear();
            textBoxSur.Clear();
            textBoxGSM.Clear();
            comboBoxDistrict.Text = "";
            comboBoxTime.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            listBoxSeat.Items.Add("Seat no 4!");
            listBoxName.Items.Add(textBoxName.Text);
            listBoxSur.Items.Add(textBoxSur.Text);
            listBoxGSM.Items.Add(textBoxGSM.Text);
            listBoxDistrict.Items.Add((object)comboBoxDistrict.Text);
            listBoxTime.Items.Add((object)comboBoxTime.Text);



            if (radioMale.Checked == true)
            {

                radioFemale.Checked = false;
                listBoxGender.Items.Add(radioMale.Text);
            }

            if (radioFemale.Checked == true)
            {
                radioMale.Checked = false;
                listBoxGender.Items.Add(radioFemale.Text);
            }
            textBoxName.Clear();
            textBoxSur.Clear();
            textBoxGSM.Clear();
            comboBoxDistrict.Text = "";
            comboBoxTime.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        private void btnP5_Click(object sender, EventArgs e)
        {
            listBoxSeat.Items.Add("Seat no 5!");
            listBoxName.Items.Add(textBoxName.Text);
            listBoxSur.Items.Add(textBoxSur.Text);
            listBoxGSM.Items.Add(textBoxGSM.Text);
            listBoxDistrict.Items.Add((object)comboBoxDistrict.Text);
            listBoxTime.Items.Add((object)comboBoxTime.Text);



            if (radioMale.Checked == true)
            {

                radioFemale.Checked = false;
                listBoxGender.Items.Add(radioMale.Text);
            }

            if (radioFemale.Checked == true)
            {
                radioMale.Checked = false;
                listBoxGender.Items.Add(radioFemale.Text);
            }
            textBoxName.Clear();
            textBoxSur.Clear();
            textBoxGSM.Clear();
            comboBoxDistrict.Text = "";
            comboBoxTime.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        private void btnP6_Click(object sender, EventArgs e)
        {
            listBoxSeat.Items.Add("Seat no 6!");
            listBoxName.Items.Add(textBoxName.Text);
            listBoxSur.Items.Add(textBoxSur.Text);
            listBoxGSM.Items.Add(textBoxGSM.Text);
            listBoxDistrict.Items.Add((object)comboBoxDistrict.Text);
            listBoxTime.Items.Add((object)comboBoxTime.Text);



            if (radioMale.Checked == true)
            {

                radioFemale.Checked = false;
                listBoxGender.Items.Add(radioMale.Text);
            }

            if (radioFemale.Checked == true)
            {
                radioMale.Checked = false;
                listBoxGender.Items.Add(radioFemale.Text);
            }
            textBoxName.Clear();
            textBoxSur.Clear();
            textBoxGSM.Clear();
            comboBoxDistrict.Text = "";
            comboBoxTime.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;
            btnP6.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3 back = new Form3();
            back.Show();
            this.Hide();
        }
    }
}
