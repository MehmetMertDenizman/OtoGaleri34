using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoNetDemoTRY
{
    internal class ProductDal
    {
        SqlConnection _connection = new SqlConnection
            (@"server = (localdb)\mssqllocaldb; initial catalog = MyTrade; integrated security = true");

        public List<Product> GetAll()
        {
            ConControl();
            SqlCommand cmd = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    Created = Convert.ToDateTime(reader["Created"]),
                };
                
            }
            return null;
        }
        public void Add(Product product)
        {
            ConControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@Name,@Price,@Stock,@Created", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@Created", product.Created);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void ConControl()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
                
        }
    }
}
