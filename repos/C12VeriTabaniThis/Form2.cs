using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C12VeriTabaniThis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Library; Integrated Security = True");
        SqlConnection conn2;
        private void Show()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Books",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["id"].ToString();
                item.SubItems.Add(dr["bookname"].ToString());
                item.SubItems.Add(dr["author"].ToString());
                item.SubItems.Add(dr["publisher"].ToString());
                item.SubItems.Add(dr["pages"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//SAVE
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert Into Books(bookname,author,publisher,pages) Values('" + textBoxBookName.Text.ToString() + "','" + textBoxAuthor.Text.ToString() + "','" + textBoxPublisher.Text.ToString() + "','" + textBoxPages.Text.ToString() + "')",conn);
            sqlCommand.ExecuteNonQuery();
            
            conn.Close();
            
        }
        int id = 0;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand del = new SqlCommand("Delete from Books where id= '"+textBoxID.Text+ "'", conn);
            del.ExecuteNonQuery();
            conn.Close();
            Show();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text =  listView1.SelectedItems[0].SubItems[0].Text;
            textBoxBookName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxAuthor.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxPublisher.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxPages.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void buttonForm3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string update = "UPDATE Books SET bookname=@bookname, author=@author, publisher=@publisher, pages=@pages where id=@id";
            SqlCommand cmd = new SqlCommand("UPDATE Books SET bookname=@bookname, author=@author, publisher=@publisher, pages=@pages where id="+Convert.ToInt32(textBoxID.Text), conn);
            cmd.Parameters.AddWithValue("id", Convert.ToInt32(textBoxID.Text));
            cmd.Parameters.AddWithValue("bookname", textBoxBookName.Text);
            cmd.Parameters.AddWithValue("author", textBoxAuthor.Text);
            cmd.Parameters.AddWithValue("publisher", textBoxPublisher.Text);
            cmd.Parameters.AddWithValue("pages", textBoxPages.Text);
            

            cmd.ExecuteNonQuery();
            conn.Close();
            Show();
        }
    }
}

//conn.Open();
//string update = "update Books set bookname=@bookname, author=@author, publisher=@publisher, pages=@pages where id=@id";
//SqlCommand cmd = new SqlCommand(update, conn);
//cmd.Parameters.AddWithValue("@bookname", textBoxBookName.Text);
//cmd.Parameters.AddWithValue("@author", textBoxAuthor.Text);
//cmd.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
//cmd.Parameters.AddWithValue("@pages", textBoxPages.Text);
//cmd.Parameters.AddWithValue("@id", textBoxID.Text);

//cmd.ExecuteNonQuery();
//conn.Close();
//Show();