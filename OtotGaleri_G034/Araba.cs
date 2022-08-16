using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtotGaleri_G034
{
    class Araba
    {
        //araba nesnesine ait veri yönetimi kodlarını içerir.
        public string Plaka;
        public string Marka;
        public float KiralamaBedeli;   
        public ARABA_TIPI ArabaTipi;
        public DURUM Durum;
        public int KiralamaSayisi
        {
            get
            {
                return KiralanmaSureleri.Count;
            }
        }
        public int ToplamKiralanmaSuresi
        {
            get
            {
                int toplam = 0;
                foreach (int sure in KiralanmaSureleri)
                {
                    toplam += sure;
                }
                return toplam;
            }
        }
        public List<int> KiralanmaSureleri = new List<int>();
        public Araba()
        {
            this.Durum= DURUM.Galeride;
        }
        public Araba(string plaka, string marka, float k_bedeli, ARABA_TIPI a_tipi)
        {
            this.Plaka = plaka;
            this.Marka = marka;
            this.KiralamaBedeli = k_bedeli;
            this.ArabaTipi = a_tipi;
        }
    }
    public enum ARABA_TIPI
    {
        Empty,SUV,Hatchback,Sedan
    }
    public enum DURUM
    {
        Empty,Kirada,Galeride
    }
}
