using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Hayvan
    {
        private string name;
        public Hayvan(string name)
        {
            this.name = name;
        }
        public string getName() {   return name;   }
        public void  setName() {   this.name = name;   }

        public virtual void speak() { Console.WriteLine(getName() + " speaking");        }
    }
    
}
