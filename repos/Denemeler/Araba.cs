using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;
        public Araba(int _kapiSayisi, string _arabaModel, string _arabaRengi)
        {
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModel;   
            arabaRengi = _arabaRengi;    
        }
        
        public void motorWork()
        {
            Console.WriteLine("Motor çalışıyor");
        }
        public void kapıLock()
        {
            Console.WriteLine("kitlendi");

        }
    }
}
