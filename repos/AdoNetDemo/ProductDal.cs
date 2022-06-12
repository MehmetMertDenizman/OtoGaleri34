using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true");
        public List<Product> GetAll()
        {


            ConControl();


            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    Price = Convert.ToInt32(reader["Price"])
                };
                products.Add(product);
            }




            return products;

            
            
        }

        public void ConControl()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

        }

        public void Add(Product product)
        {
            ConControl();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@Name,@Price,@Stock)", _connection);
             
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();
            _connection.Close();
            
        }



    }
}
