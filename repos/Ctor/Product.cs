using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    internal class Product
    {
        
        public int ID { get; set; }

        public string Name { get; set; }
        private int _id;
        public string _Name;
        public Product(int id, string name)
        {
            _id = id;
            _Name = name;
        }
        public Product()
        {

        }
    }
}
