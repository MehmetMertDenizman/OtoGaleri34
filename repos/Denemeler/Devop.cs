using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Denemeler
{
    public class Devop : Personel
    {
        private string diller;
        public Devop(int ID, string name, string sur,string diller) : base(ID, name, sur)
        {
            this.diller = diller;
        }
        public void formatAt(string isletim_sistemi)
        {
            Console.WriteLine(getName() + "şu anda" + " " + isletim_sistemi + "format atıyor");
        }
    }

}
