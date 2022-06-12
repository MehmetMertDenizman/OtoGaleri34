using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class SecondClass
    {
        private void privateMethod()
        {
            Console.WriteLine("Private de çalıştı");
        }
        protected void protectedMethod()
        {
            Console.WriteLine("Protected çalıştı lan");
        }
    }
}
