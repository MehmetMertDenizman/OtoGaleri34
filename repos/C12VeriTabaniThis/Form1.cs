using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C12VeriTabaniThis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True");

        private void dataShow()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["Name"].ToString();
                add.SubItems.Add(dr["Surname"].ToString());
                add.SubItems.Add(dr["City"].ToString());
                add.SubItems.Add(dr["School"].ToString());
                View.Items.Add(add);
                
            }
            sql.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Kayıtlar;Integrated Security=True");
        private void Add()
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("Select * from Received", conn);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["Name"].ToString();
                item.SubItems.Add(reader["Surname"].ToString());
                item.SubItems.Add(reader["Corp"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataShow();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Insert into Received (Name, Surname, Corp) Values ('" + textBoxName2.Text.ToString() + "', '" + textBoxSur2.Text.ToString() + "','" + textBoxCorp.Text.ToString() + "')", conn);
            
            komut.ExecuteNonQuery();
            conn.Close();
            Add();
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            sql.Open();   
            SqlCommand komut = new SqlCommand("Insert into Student (Name, Surname, City, School) Values('"+ textBoxName.Text.ToString()+"', '"+textBoxSur.Text.ToString()+"','"+ textBoxCity.Text.ToString()+"','" + textBoxSchool.Text.ToString() + "'  )",sql);
            
            komut.ExecuteNonQuery();
            sql.Close();
            dataShow();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
            
        }
    }
}
