using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    public class MySql : ICustomer
    {
        public void add()
    {
        Console.WriteLine("anananna eklendi mysql");
    }

    public void delete()
    {
        Console.WriteLine("Ananı sildim mysql");
    }

    public void update()
    {
        Console.WriteLine("Update ettim mysql");
    }
    }
}

