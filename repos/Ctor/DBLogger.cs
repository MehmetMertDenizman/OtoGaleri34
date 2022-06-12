using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    internal class DBLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged Database"); ;
        }
    }
}
