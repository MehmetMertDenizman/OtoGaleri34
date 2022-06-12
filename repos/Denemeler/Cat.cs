using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Cat:Hayvan
    {
        public Cat(string name):base(name)
        {
                        
        }
        public override void speak()
        {
            Console.WriteLine(getName() + " meow did");
        }
    }
}
