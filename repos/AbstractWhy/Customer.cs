using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWhy
{
    public class Customer
    {
        public Customer(int ID, string CustomerName, string SurName)
        {
            this.ID = ID;
            this.CustomerName = CustomerName;
            this.SurName = SurName;
        }
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeID { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }

        public static ArrayList customer = new ArrayList();

        public CustomerState  customerAdd(Customer M1)
        {
            customer.Add(M1);
            
            return CustomerState.regOK;

        }
        
    }
}
