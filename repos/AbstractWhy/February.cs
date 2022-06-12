using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWhy
{
    public class February:IAy
    {
        public override int HowManyDays()
        {
            return 28;
        }

       

        public override int WhichMonth()
        {
            return 2;
        }
    }
}
