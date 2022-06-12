using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class CusControl : Sql
    {
        public void customerAdd(ICustomer  database)
        {
            database.add();
               

        }
    }
}
