using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWhy
{
    public class January : IAy
    {
        public override int HowManyDays()
        {
            return 31;
        }

        

        public override int WhichMonth()
        {
            return 1;
        }
    }
}
