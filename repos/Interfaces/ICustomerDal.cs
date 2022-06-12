using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class Oracle : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }
        public void Update()
        {
            Console.WriteLine("Updated Oracle");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted Oracle");
        }
    }
    class Sql : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }
        public void Update()
        {
            Console.WriteLine("Updated Sql");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted Sql");
        }
    }

    
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
            customerDal.Update();
            customerDal.Delete();
        }
    }
}
