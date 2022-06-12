using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl
{
    public class Customer

    {
        public Customer(int ID, string Name, string SurName, string eMail)         
        {
            this.ID = ID;
            this.Name = Name;
            this.SurName = SurName;
            this.eMail = eMail;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string eMail { get; set; }
        public override string ToString()
        {
            return "ID: " + this.ID + "Name: " + this.Name + "Surname: " + this.SurName + "Email: " + this.eMail;
    }
    }
    
         
    
}
