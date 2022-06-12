using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal
{
    public class InternalAccess
    {
        public void publicMethod()
        {
            Console.WriteLine("public bu");
        }
        internal void internalMethod()
        {
            Console.WriteLine("Internal da çalıştı");
        }
    }
}
