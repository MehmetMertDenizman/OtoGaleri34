using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    internal class EmpManager
    {
        ILogger _logger;
        public EmpManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()

        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
}
