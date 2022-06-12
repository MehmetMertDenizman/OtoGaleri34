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

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert Into Books(id,bookname,author,publisher,pages) Values('" + textBoxID.Text.ToString() + "', '" + textBoxName.Text.ToString() + "','" + textBoxAuthor.Text.ToString() + "','" + textBoxPublisher.Text.ToString() + "','" + textBoxPages.Text.ToString() + "')",conn);
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

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text =  listView1.SelectedItems[0].SubItems[0].Text;
            textBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxAuthor.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
