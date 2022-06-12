using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    internal class PersonMan : BaseClass
    {
        public PersonMan(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Veritabanuna eklendi");
            Message();
        }
    }
}
