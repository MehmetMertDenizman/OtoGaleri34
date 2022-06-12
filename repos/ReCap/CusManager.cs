using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCap
{
    internal class CusManager
    {
        public ILogger rogger { get; set; }
        public void Add()
        {
            rogger.Log();
            Logger togger = new Logger();
            togger.Log();
            Console.WriteLine("Cus Added");
        }

    }
}
