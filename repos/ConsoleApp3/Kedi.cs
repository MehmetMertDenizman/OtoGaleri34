using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Kedi : Hayvan
    {
        public Kedi(string _name) : base(_name)
        {
            name = _name;
        }
        public override void speak()
        {
            Console.WriteLine(getName() +" Miyav");
        }
    }
}
