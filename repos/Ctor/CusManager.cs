using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    internal class CusManager
    {
        int i = 5;
        int hp = 11;
        private int _count;
        public CusManager()
        {

        }
        public CusManager(int count)
        {
            _count = count;
            i = 13;
            hp = 15;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items " , _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public int Hp()
        {
            return hp;
            return i;
        }
    }
}
