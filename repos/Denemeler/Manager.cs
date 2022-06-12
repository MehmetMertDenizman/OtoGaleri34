using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Manager : Personel
    {
        private int underlings;
        public Manager(int ID, string name, string sur, int underlings) : base(ID, name, sur)
        {
            this.underlings = underlings;
        }
        public  void zam(int zamAmount)
        {
            Console.WriteLine(getName() + " " + zamAmount + " " + "Tl arttı."); 
        }
    }
}
