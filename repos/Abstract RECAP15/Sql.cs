using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Sql : ICustomer
    {
        public void add()
        {
            Console.WriteLine("anananna eklendi sql");
        }

        public void delete()
        {
            Console.WriteLine("Ananı sildim sql") ;
        }

        public void update()
        {
            Console.WriteLine("Update ettim sql");
        }
    }
}
