using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    class Kapsul
    {
        private int kilo;
        private string isim;
        public int kiloGet { get; set; }

        public void setName(string _isim)
        {
            isim = _isim;
        }
        public string getName()
        {
            return isim;
        }
    }
    
}